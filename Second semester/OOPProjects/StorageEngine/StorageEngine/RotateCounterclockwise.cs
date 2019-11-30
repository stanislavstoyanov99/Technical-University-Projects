using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageEngine
{
    public partial class RotateCounterclockwise : Form
    {
        public RotateCounterclockwise()
        {
            InitializeComponent();
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextbox.Text) || string.IsNullOrEmpty(VoltageAmount.Text))
            {
                MessageBox.Show("Моля въведете полето/полетата.");
                Clear();
            }
            else
            {
                string voltageAmount = VoltageAmount.Text.Trim();
                string id = IdTextbox.Text.Trim();
                string patternForValidation = @"^[0-9]*$";

                // Validation
                if (!Regex.IsMatch(voltageAmount, patternForValidation) || !Regex.IsMatch(id, patternForValidation))
                {
                    MessageBox.Show("Моля въведете само цифри.");
                    Clear();
                    return;
                }

                // Main logic
                int voltageFromUser = int.Parse(voltageAmount);
                int engineId = int.Parse(id);

                if (chooseList.Text == "Asynchrone")
                {
                    AcEngine acEngine = new AcEngine();
                    using (EngineDbContext db = new EngineDbContext())
                    {
                        acEngine = db.AcEngines.Where(x => x.Id == engineId).FirstOrDefault();
                        if (acEngine == null)
                        {
                            MessageBox.Show("Не съществува такова ид в базата данни.");
                            Clear();
                            return;
                        }
                    }

                    int maximumAllowedRpm = acEngine.Rpm;
                    acEngine.RotateCounterClockwize(voltageFromUser, maximumAllowedRpm);
                }
                else if (chooseList.Text == "Dc")
                {
                    DcEngine dcEngine = new DcEngine();
                    using (EngineDbContext db = new EngineDbContext())
                    {
                        dcEngine = db.DcEngines.Where(x => x.Id == engineId).FirstOrDefault();
                        if (dcEngine == null)
                        {
                            MessageBox.Show("Не съществува такова ид в базата данни.");
                            Clear();
                            return;
                        }
                    }

                    int maximumAllowedRpm = dcEngine.Rpm;
                    dcEngine.RotateCounterClockwize(voltageFromUser, maximumAllowedRpm);
                }
                else
                {
                    MessageBox.Show("Моля изберете тип двигател.");
                    Clear();
                    return;
                }

                Clear();
            }
        }

        private void Clear()
        {
            VoltageAmount.Text = string.Empty;
            IdTextbox.Text = string.Empty;
        }
    }
}
