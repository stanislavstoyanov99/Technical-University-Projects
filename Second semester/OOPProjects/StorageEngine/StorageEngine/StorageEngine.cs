using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace StorageEngine
{
    public partial class StorageEngine : Form
    {
        public StorageEngine()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //Validation rules
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Моля заредете първо данните с бутона \"Прегледай\".");
                Clear();
                return;
            }

            if (chooseList.Text == string.Empty)
            {
                MessageBox.Show("Моля изберете първо тип двигател за добавяне.");
                return;
            }
            else if (string.IsNullOrEmpty(PriceRedTextbox.Text) || string.IsNullOrEmpty(PriceGreenTextbox.Text)
                || string.IsNullOrEmpty(CapacityTextbox.Text) || string.IsNullOrEmpty(VoltageTextbox.Text)
                || string.IsNullOrEmpty(RpmTextbox.Text) || string.IsNullOrEmpty(AmperageTextbox.Text))
            {
                MessageBox.Show("Моля въведете всички полета.");
                Clear();
                return;
            }

            string idAsString = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
            string priceRedCardAsString = PriceRedTextbox.Text.Trim();
            string priceGreenCardAsString = PriceGreenTextbox.Text.Trim();
            string capacityAsString = CapacityTextbox.Text.Trim();
            string voltageAsString = VoltageTextbox.Text.Trim();
            string rpmAsString = RpmTextbox.Text.Trim();
            string amperageAsString = AmperageTextbox.Text.Trim();

            string patternForValidation = @"^[0-9]*$";
            if (!Regex.IsMatch(idAsString, patternForValidation) || !Regex.IsMatch(priceRedCardAsString, patternForValidation)
                || !Regex.IsMatch(priceGreenCardAsString, patternForValidation)
                || !Regex.IsMatch(capacityAsString, patternForValidation)
                || !Regex.IsMatch(voltageAsString, patternForValidation) || !Regex.IsMatch(rpmAsString, patternForValidation)
                || !Regex.IsMatch(amperageAsString, patternForValidation))
            {
                MessageBox.Show("Невалидни данни за вход. Моля въведете само цифри.");
                Clear();
                return;
            }

            // Parsing string to data variables
            int id = Convert.ToInt32(idAsString);
            decimal priceRedCard = decimal.Parse(priceRedCardAsString);
            decimal priceGreenCard = decimal.Parse(priceGreenCardAsString);
            double capacity = double.Parse(capacityAsString);
            int voltage = int.Parse(voltageAsString);
            int rpm = int.Parse(rpmAsString);
            int amperage = int.Parse(amperageAsString);

            // Main logic
            if (chooseList.Text == "Asynchrone")
            {
                AcEngine acEngine = new AcEngine(id, priceRedCard, priceGreenCard, capacity, voltage, rpm, amperage);

                using (EngineDbContext db = new EngineDbContext())
                {
                    // Update information
                    if (AddBtn.Text == "Ъпдейт")
                    {
                        db.Entry(acEngine).State = EntityState.Modified;
                    }
                    else // Add information
                    {
                        db.AcEngines.Add(acEngine);
                        Counter(true);
                    }

                    db.SaveChanges();
                }

                Clear();
                ShowDataGridView();
                MessageBox.Show("Submitted successfully.");
            }
            else if (chooseList.Text == "Dc")
            {
                DcEngine dcEngine = new DcEngine(id, priceRedCard, priceGreenCard, capacity, voltage, rpm, amperage);

                using (EngineDbContext db = new EngineDbContext())
                {
                    // Update information
                    if (AddBtn.Text == "Ъпдейт")
                    {
                        db.Entry(dcEngine).State = EntityState.Modified;
                    }
                    else // Add information
                    {
                        db.DcEngines.Add(dcEngine);
                        Counter(true);
                    }
                    db.SaveChanges();
                }

                Clear();
                ShowDataGridView();
                MessageBox.Show("Submitted successfully.");
            }
            else if (chooseList.Text == "Generator")
            {
                Generator generator = new Generator(id, priceRedCard, priceGreenCard, capacity, voltage, rpm, amperage);

                using (EngineDbContext db = new EngineDbContext())
                {
                    // Update information
                    if (AddBtn.Text == "Ъпдейт")
                    {
                        db.Entry(generator).State = EntityState.Modified;
                    }
                    else // Add information
                    {
                        db.Generators.Add(generator);
                        Counter(true);
                    }
                    db.SaveChanges();
                }

                Clear();
                ShowDataGridView();
                MessageBox.Show("Submitted successfully.");
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(chooseList.Text))
            {
                ShowDataGridView();
            }
            else
            {
                MessageBox.Show("Моля изберете първо тип двигател.");
            }
        }

        private void ShowDataGridView()
        {
            using (EngineDbContext db = new EngineDbContext())
            {
                if (chooseList.Text == "Asynchrone" && db.AcEngines.Any())
                {
                    dataGridView.DataSource = db.AcEngines.ToList();
                    countLabel.Text = dataGridView.RowCount.ToString();
                }
                else if (chooseList.Text == "Dc" && db.DcEngines.Any())
                {
                    dataGridView.DataSource = db.DcEngines.ToList();
                    countLabel.Text = dataGridView.RowCount.ToString();
                }
                else if (chooseList.Text == "Generator" && db.Generators.Any())
                {
                    dataGridView.DataSource = db.Generators.ToList();
                    countLabel.Text = dataGridView.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Няма записи в базата данни.");
                }
            }
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            // Validation rule
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Моля заредете първо данните с бутона \"Прегледай\".");
                return;
            }

            // Main logic
            if (dataGridView.CurrentRow.Index != -1)
            {
                if (chooseList.Text == "Asynchrone")
                {
                    AcEngine updatedAcEngine = new AcEngine
                    {
                        Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value)
                    };

                    using (EngineDbContext db = new EngineDbContext())
                    {
                        updatedAcEngine = db.AcEngines.Where(x => x.Id == updatedAcEngine.Id).FirstOrDefault();

                        PriceRedTextbox.Text = updatedAcEngine.PriceRedCard.ToString();
                        PriceGreenTextbox.Text = updatedAcEngine.PriceGreenCard.ToString();
                        CapacityTextbox.Text = updatedAcEngine.Capacity.ToString();
                        VoltageTextbox.Text = updatedAcEngine.Voltage.ToString();
                        RpmTextbox.Text = updatedAcEngine.Rpm.ToString();
                        AmperageTextbox.Text = updatedAcEngine.Amperage.ToString();
                    }

                    AddBtn.Text = "Ъпдейт";
                    DeleteBtn.Enabled = true;
                }
                else if (chooseList.Text == "Dc")
                {
                    DcEngine updatedDcEngine = new DcEngine
                    {
                        Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value)
                    };

                    using (EngineDbContext db = new EngineDbContext())
                    {
                        updatedDcEngine = db.DcEngines.Where(x => x.Id == updatedDcEngine.Id).FirstOrDefault();

                        PriceRedTextbox.Text = updatedDcEngine.PriceRedCard.ToString();
                        PriceGreenTextbox.Text = updatedDcEngine.PriceGreenCard.ToString();
                        CapacityTextbox.Text = updatedDcEngine.Capacity.ToString();
                        VoltageTextbox.Text = updatedDcEngine.Voltage.ToString();
                        RpmTextbox.Text = updatedDcEngine.Rpm.ToString();
                        AmperageTextbox.Text = updatedDcEngine.Amperage.ToString();
                    }

                    AddBtn.Text = "Ъпдейт";
                    DeleteBtn.Enabled = true;
                }
                else if (chooseList.Text == "Generator")
                {
                    Generator updatedGenerator = new Generator
                    {
                        Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value)
                    };

                    using (EngineDbContext db = new EngineDbContext())
                    {
                        updatedGenerator = db.Generators.Where(x => x.Id == updatedGenerator.Id).FirstOrDefault();

                        PriceRedTextbox.Text = updatedGenerator.PriceRedCard.ToString();
                        PriceGreenTextbox.Text = updatedGenerator.PriceGreenCard.ToString();
                        CapacityTextbox.Text = updatedGenerator.Capacity.ToString();
                        VoltageTextbox.Text = updatedGenerator.Voltage.ToString();
                        RpmTextbox.Text = updatedGenerator.Rpm.ToString();
                        AmperageTextbox.Text = updatedGenerator.Amperage.ToString();
                    }

                    AddBtn.Text = "Ъпдейт";
                    DeleteBtn.Enabled = true;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Validation message
            bool confirmation = MessageBox.Show("Сигурни ли сте, че искате да изтриете данните?", "Изтриване", MessageBoxButtons.YesNo)
                == DialogResult.Yes;

            // Main logic
            if (confirmation)
            {
                using (EngineDbContext db = new EngineDbContext())
                {
                    if (chooseList.Text == "Asynchrone")
                    {
                        AcEngine acEngineToDelete = new AcEngine
                        {
                            Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value)
                        };

                        var entry = db.Entry(acEngineToDelete);
                        if (entry.State == EntityState.Detached)
                        {
                            db.AcEngines.Attach(acEngineToDelete);
                        }

                        db.AcEngines.Remove(acEngineToDelete);
                        Counter(false);
                        db.SaveChanges();
                        ShowDataGridView();
                        Clear();
                        MessageBox.Show("Deleted successfully.");
                    }
                    else if (chooseList.Text == "Dc")
                    {
                        DcEngine dcEngineToDelete = new DcEngine
                        {
                            Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value)
                        };

                        var entry = db.Entry(dcEngineToDelete);
                        if (entry.State == EntityState.Detached)
                        {
                            db.DcEngines.Attach(dcEngineToDelete);
                        }

                        db.DcEngines.Remove(dcEngineToDelete);
                        Counter(false);
                        db.SaveChanges();
                        ShowDataGridView();
                        Clear();
                        MessageBox.Show("Deleted successfully.");
                    }
                    else if (chooseList.Text == "Generator")
                    {
                        Generator generatorToDelete = new Generator
                        {
                            Id = Convert.ToInt32(dataGridView.CurrentRow.Cells["Id"].Value)
                        };

                        var entry = db.Entry(generatorToDelete);
                        if (entry.State == EntityState.Detached)
                        {
                            db.Generators.Attach(generatorToDelete);
                        }

                        db.Generators.Remove(generatorToDelete);
                        Counter(false);
                        db.SaveChanges();
                        ShowDataGridView();
                        Clear();
                        MessageBox.Show("Deleted successfully.");
                    }
                }
            }
        }

        private void RotateClockwiseBtn_Click(object sender, EventArgs e)
        {
            RotateClockwise form = new RotateClockwise();
            form.ShowDialog();
        }

        private void RotateCounterclockwiseBtn_Click(object sender, EventArgs e)
        {
            RotateCounterclockwise form = new RotateCounterclockwise();
            form.ShowDialog();
        }

        private void KpdBtn_Click(object sender, EventArgs e)
        {
            CalculateKpd form = new CalculateKpd();
            form.ShowDialog();
        }

        private void ExportDataBtn_Click(object sender, EventArgs e)
        {
            if (chooseList.Text == "Asynchrone")
            {
                Serialize();
                Deserialize();
            }
            else if (chooseList.Text == "Dc")
            {
                Serialize();
                Deserialize();
            }
            else if (chooseList.Text == "Generator")
            {
                Serialize();
                Deserialize();
            }
            else
            {
                MessageBox.Show("Моля изберете двигател за експорт на данните.");
                return;
            }

            if (backgroundWorker.IsBusy)
            {
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputParameter.FileName = sfd.FileName;

                    using (EngineDbContext db = new EngineDbContext())
                    {
                        if (chooseList.Text == "Asynchrone")
                        {
                            _inputParameter.EngineList = db.AcEngines.ToList();
                        }
                        else if (chooseList.Text == "Dc")
                        {
                            // TODO
                            MessageBox.Show("В процес на разработка.");
                            return;
                        }
                        else if (chooseList.Text == "Generator")
                        {
                            // TODO
                            MessageBox.Show("В процес на разработка.");
                            return;
                        }
                    }

                    progressBarExport.Minimum = 0;
                    progressBarExport.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputParameter);
                }
            }
        }

        private void GenerateAmperageBtn_Click(object sender, EventArgs e)
        {
            if (chooseList.Text == "Generator")
            {
                GenerateEnergy form = new GenerateEnergy();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Моля изберeте за тип на двигателя - генератор");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (chooseList.Text == "Asynchrone")
            {
                using (EngineDbContext db = new EngineDbContext())
                {
                    var foundModel = db.AcEngines.Where(x => x.Id.ToString() == IdTextbox.Text).ToList();
                    if (foundModel.Count != 0)
                    {
                        dataGridView.DataSource = foundModel.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Не съществува такова ид.");
                        IdTextbox.Text = string.Empty;
                    }
                }
            }
            else if (chooseList.Text == "Dc")
            {
                using (EngineDbContext db = new EngineDbContext())
                {
                    var foundModel = db.DcEngines.Where(x => x.Id.ToString() == IdTextbox.Text).ToList();
                    if (foundModel.Count != 0)
                    {
                        dataGridView.DataSource = foundModel.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Не съществува такова ид.");
                        IdTextbox.Text = string.Empty;
                    }
                }
            }
            else if (chooseList.Text == "Generator")
            {
                using (EngineDbContext db = new EngineDbContext())
                {
                    var foundModel = db.Generators.Where(x => x.Id.ToString() == IdTextbox.Text).ToList();
                    if (foundModel.Count != 0)
                    {
                        dataGridView.DataSource = foundModel.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Не съществува такова ид.");
                        IdTextbox.Text = string.Empty;
                    }
                }
            }
            else
            {
                MessageBox.Show("Моля изберете първо тип двигател.");
                IdTextbox.Text = string.Empty;
            }
        }

        private void Clear()
        {
            PriceRedTextbox.Text = string.Empty;
            PriceGreenTextbox.Text = string.Empty;
            CapacityTextbox.Text = string.Empty;
            VoltageTextbox.Text = string.Empty;
            RpmTextbox.Text = string.Empty;
            AmperageTextbox.Text = string.Empty;
            IdTextbox.Text = string.Empty;

            AddBtn.Text = "Добави";
            DeleteBtn.Enabled = false;
        }

        private void Counter(bool IncrementOrDecrement)
        {
            int counter = 0;

            if (IncrementOrDecrement == true)
            {
                counter = dataGridView.RowCount;
            }
            else
            {
                counter = dataGridView.RowCount - 1;
            }

            countLabel.Text = counter.ToString();
        }

        struct DataParameter
        {
            public List<AcEngine> EngineList;

            public string FileName { get; set; }
        }

        DataParameter _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (EngineDbContext db = new EngineDbContext())
            {
                var engineList = ((DataParameter)e.Argument).EngineList;

                // Create worksheet and workbook in excel using outer assembly Microsoft.Interlop.Excel
                string fileName = ((DataParameter)e.Argument).FileName;
                var excel = new Microsoft.Office.Interop.Excel.Application();
                var wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                var ws = (Worksheet)excel.ActiveSheet;

                excel.Visible = false;
                int process = engineList.Count();
                int index = 1;

                // Add columns
                ws.Cells[1, 1] = "EngineId";
                ws.Cells[1, 2] = "PriceRedCard";
                ws.Cells[1, 3] = "PriceGreenCard";
                ws.Cells[1, 4] = "Capacity";
                ws.Cells[1, 5] = "Rpm";
                ws.Cells[1, 6] = "Amperage";
                ws.Cells[1, 7] = "Voltage";
                ws.Cells[1, 8] = "Frequency";

                foreach (AcEngine engine in engineList)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process);
                    }

                    ws.Cells[index, 1] = engine.Id;
                    ws.Cells[index, 2] = engine.PriceRedCard;
                    ws.Cells[index, 3] = engine.PriceGreenCard;
                    ws.Cells[index, 4] = engine.Capacity;
                    ws.Cells[index, 5] = engine.Rpm;
                    ws.Cells[index, 6] = engine.Amperage;
                    ws.Cells[index, 7] = engine.Voltage;
                    ws.Cells[index, 8] = engine.Frequency;
                }

                // Save file into excel worksheet
                ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                    true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                excel.Quit();

                db.SaveChanges();
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarExport.Value = e.ProgressPercentage;
            ExportLabel.Text = string.Format("Processing...{0}%", e.ProgressPercentage);
            progressBarExport.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(200);
                ExportLabel.Text = "Your data has been successfully exported.";
            }
        }

        private void Serialize()
        {
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream("data.db", FileMode.Create, FileAccess.Write))
            {
                using (EngineDbContext db = new EngineDbContext())
                {
                    if (chooseList.Text == "Asynchrone")
                    {
                        var acList = db.AcEngines.ToList();
                        formatter.Serialize(stream, acList);
                    }
                    else if (chooseList.Text == "Dc")
                    {
                        var dcList = db.DcEngines.ToList();
                        formatter.Serialize(stream, dcList);
                    }
                    else if (chooseList.Text == "Generator")
                    {
                        var generatorList = db.Generators.ToList();
                        formatter.Serialize(stream, generatorList);
                    }
                }
            }
        }

        private void Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new FileStream("data.db", FileMode.Open, FileAccess.Read))
            {
                using (EngineDbContext db = new EngineDbContext())
                {
                    if (chooseList.Text == "Asynchrone")
                    {
                        var acList = db.AcEngines.ToList();
                        acList = (List<AcEngine>)formatter.Deserialize(stream);
                    }
                    else if (chooseList.Text == "Dc")
                    {
                        var dcList = db.DcEngines.ToList();
                        dcList = (List<DcEngine>)formatter.Deserialize(stream);
                    }
                    else if (chooseList.Text == "Generator")
                    {
                        var generatorList = db.Generators.ToList();
                        generatorList = (List<Generator>)formatter.Deserialize(stream);
                    }
                }
            }
        }
    }
}
