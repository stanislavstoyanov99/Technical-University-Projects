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
    public partial class CalculateKpd : Form
    {
        public CalculateKpd()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdTextbox.Text))
            {
                MessageBox.Show("Моля въведете полето за ид.");
                Clear();
            }
            else
            {
                string id = IdTextbox.Text.Trim();
                string patternForValidation = @"^[0-9]*$";

                // Validation
                if (!Regex.IsMatch(id, patternForValidation))
                {
                    MessageBox.Show("Моля въведете само цифри.");
                    Clear();
                    return;
                }

                // Main logic
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

                    acEngine.CalculateKPD(acEngine.Capacity, acEngine.Voltage, acEngine.Amperage);
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

                    dcEngine.CalculateKPD(dcEngine.Capacity, dcEngine.Voltage, dcEngine.Amperage);
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
            IdTextbox.Text = string.Empty;
        }
    }
}
