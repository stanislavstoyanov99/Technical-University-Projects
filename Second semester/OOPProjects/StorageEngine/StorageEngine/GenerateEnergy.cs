using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StorageEngine
{
    public partial class GenerateEnergy : Form
    {
        public GenerateEnergy()
        {
            InitializeComponent();
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }

        private async void GenerateAmperageBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RpmAmount.Text) || string.IsNullOrEmpty(IdTextbox.Text))
            {
                MessageBox.Show("Моля въведете полето/полетата.");
                Clear();
            }
            else
            {
                string rpmAmount = RpmAmount.Text.Trim();
                string id = IdTextbox.Text.Trim();
                string patternForValidation = @"^[0-9]*$";

                // Validation
                if (!Regex.IsMatch(rpmAmount, patternForValidation) || !Regex.IsMatch(id, patternForValidation))
                {
                    MessageBox.Show("Моля въведете само цифри.");
                    Clear();
                    return;
                }

                // Main logic
                int rpmFromUser = int.Parse(rpmAmount);
                int generatorId = int.Parse(id);

                Generator generator = new Generator();

                using (EngineDbContext db = new EngineDbContext())
                {
                    generator = db.Generators.Where(x => x.Id == generatorId).FirstOrDefault();
                    if (generator == null)
                    {
                        MessageBox.Show("Не съществува такова ид в базата данни.");
                        Clear();
                        return;
                    }
                }

                // Progress bar logic
                List<string> list = new List<string>();
                for (int i = 0; i < 800; i++)
                {
                    list.Add(i.ToString());
                }

                ProcessingStatus.Text = "Зареждане...";
                var progress = new Progress<ProgressReport>();
                progress.ProgressChanged += (o, report) =>
                {
                    ProcessingStatus.Text = string.Format($"Обработване...{report.PercentComplete}%");
                    ProgressBar.Value = report.PercentComplete;
                    ProgressBar.Update();
                };

                await ProcessData(list, progress);
                generator.ProduceEnergy(rpmFromUser);

                ProcessingStatus.Text = "Готово!";
                Clear();
            }
        }

        private void Clear()
        {
            RpmAmount.Text = string.Empty;
            IdTextbox.Text = string.Empty;
        }
    }
}
