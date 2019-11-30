namespace StorageEngine
{
    partial class StorageEngine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageEngine));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.chooseList = new System.Windows.Forms.ComboBox();
            this.AmperageTextbox = new System.Windows.Forms.TextBox();
            this.RpmTextbox = new System.Windows.Forms.TextBox();
            this.VoltageTextbox = new System.Windows.Forms.TextBox();
            this.CapacityTextbox = new System.Windows.Forms.TextBox();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.amperageLabel = new System.Windows.Forms.Label();
            this.PriceGreenTextbox = new System.Windows.Forms.TextBox();
            this.PriceRedTextbox = new System.Windows.Forms.TextBox();
            this.priceGreenCardLabel = new System.Windows.Forms.Label();
            this.priceRedCardLabel = new System.Windows.Forms.Label();
            this.operationsBox = new System.Windows.Forms.GroupBox();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.ExportLabel = new System.Windows.Forms.Label();
            this.KpdBtn = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ExportDataBtn = new System.Windows.Forms.Button();
            this.GenerateAmperageBtn = new System.Windows.Forms.Button();
            this.RotateCounterclockwiseBtn = new System.Windows.Forms.Button();
            this.RotateClockwiseBtn = new System.Windows.Forms.Button();
            this.txtRecords = new System.Windows.Forms.Label();
            this.TotalNumber = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.infoBox.SuspendLayout();
            this.operationsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.infoBox.Controls.Add(this.IdLabel);
            this.infoBox.Controls.Add(this.IdTextbox);
            this.infoBox.Controls.Add(this.chooseLabel);
            this.infoBox.Controls.Add(this.chooseList);
            this.infoBox.Controls.Add(this.AmperageTextbox);
            this.infoBox.Controls.Add(this.RpmTextbox);
            this.infoBox.Controls.Add(this.VoltageTextbox);
            this.infoBox.Controls.Add(this.CapacityTextbox);
            this.infoBox.Controls.Add(this.rpmLabel);
            this.infoBox.Controls.Add(this.voltageLabel);
            this.infoBox.Controls.Add(this.capacityLabel);
            this.infoBox.Controls.Add(this.amperageLabel);
            this.infoBox.Controls.Add(this.PriceGreenTextbox);
            this.infoBox.Controls.Add(this.PriceRedTextbox);
            this.infoBox.Controls.Add(this.priceGreenCardLabel);
            this.infoBox.Controls.Add(this.priceRedCardLabel);
            this.infoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoBox.Location = new System.Drawing.Point(12, 25);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(941, 239);
            this.infoBox.TabIndex = 0;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Информация за двигателя";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(30, 90);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(160, 25);
            this.IdLabel.TabIndex = 20;
            this.IdLabel.Text = "Ид за търсене";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextbox.Location = new System.Drawing.Point(260, 88);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(180, 27);
            this.IdTextbox.TabIndex = 19;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(30, 38);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(194, 25);
            this.chooseLabel.TabIndex = 18;
            this.chooseLabel.Text = "Избери двигател:";
            // 
            // chooseList
            // 
            this.chooseList.BackColor = System.Drawing.SystemColors.Window;
            this.chooseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseList.FormattingEnabled = true;
            this.chooseList.Items.AddRange(new object[] {
            "Asynchrone",
            "Dc",
            "Generator"});
            this.chooseList.Location = new System.Drawing.Point(260, 35);
            this.chooseList.Name = "chooseList";
            this.chooseList.Size = new System.Drawing.Size(180, 33);
            this.chooseList.Sorted = true;
            this.chooseList.TabIndex = 17;
            // 
            // AmperageTextbox
            // 
            this.AmperageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmperageTextbox.Location = new System.Drawing.Point(718, 124);
            this.AmperageTextbox.Name = "AmperageTextbox";
            this.AmperageTextbox.Size = new System.Drawing.Size(180, 27);
            this.AmperageTextbox.TabIndex = 15;
            // 
            // RpmTextbox
            // 
            this.RpmTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RpmTextbox.Location = new System.Drawing.Point(718, 85);
            this.RpmTextbox.Name = "RpmTextbox";
            this.RpmTextbox.Size = new System.Drawing.Size(180, 27);
            this.RpmTextbox.TabIndex = 14;
            // 
            // VoltageTextbox
            // 
            this.VoltageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltageTextbox.Location = new System.Drawing.Point(718, 165);
            this.VoltageTextbox.Name = "VoltageTextbox";
            this.VoltageTextbox.Size = new System.Drawing.Size(180, 27);
            this.VoltageTextbox.TabIndex = 13;
            // 
            // CapacityTextbox
            // 
            this.CapacityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityTextbox.Location = new System.Drawing.Point(260, 201);
            this.CapacityTextbox.Name = "CapacityTextbox";
            this.CapacityTextbox.Size = new System.Drawing.Size(180, 27);
            this.CapacityTextbox.TabIndex = 12;
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpmLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rpmLabel.Location = new System.Drawing.Point(535, 87);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(185, 25);
            this.rpmLabel.TabIndex = 10;
            this.rpmLabel.Text = "Обороти-минута";
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.voltageLabel.Location = new System.Drawing.Point(535, 164);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(139, 25);
            this.voltageLabel.TabIndex = 9;
            this.voltageLabel.Text = "Напрежение";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.capacityLabel.Location = new System.Drawing.Point(30, 200);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(107, 25);
            this.capacityLabel.TabIndex = 8;
            this.capacityLabel.Text = "Мощност";
            // 
            // amperageLabel
            // 
            this.amperageLabel.AutoSize = true;
            this.amperageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amperageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.amperageLabel.Location = new System.Drawing.Point(535, 123);
            this.amperageLabel.Name = "amperageLabel";
            this.amperageLabel.Size = new System.Drawing.Size(48, 25);
            this.amperageLabel.TabIndex = 7;
            this.amperageLabel.Text = "Ток";
            // 
            // PriceGreenTextbox
            // 
            this.PriceGreenTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceGreenTextbox.Location = new System.Drawing.Point(260, 162);
            this.PriceGreenTextbox.Name = "PriceGreenTextbox";
            this.PriceGreenTextbox.Size = new System.Drawing.Size(180, 27);
            this.PriceGreenTextbox.TabIndex = 6;
            // 
            // PriceRedTextbox
            // 
            this.PriceRedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceRedTextbox.Location = new System.Drawing.Point(260, 124);
            this.PriceRedTextbox.Name = "PriceRedTextbox";
            this.PriceRedTextbox.Size = new System.Drawing.Size(180, 27);
            this.PriceRedTextbox.TabIndex = 5;
            // 
            // priceGreenCardLabel
            // 
            this.priceGreenCardLabel.AutoSize = true;
            this.priceGreenCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceGreenCardLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.priceGreenCardLabel.Location = new System.Drawing.Point(30, 161);
            this.priceGreenCardLabel.Name = "priceGreenCardLabel";
            this.priceGreenCardLabel.Size = new System.Drawing.Size(218, 25);
            this.priceGreenCardLabel.TabIndex = 3;
            this.priceGreenCardLabel.Text = "Цена - зелена карта";
            // 
            // priceRedCardLabel
            // 
            this.priceRedCardLabel.AutoSize = true;
            this.priceRedCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceRedCardLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.priceRedCardLabel.Location = new System.Drawing.Point(30, 123);
            this.priceRedCardLabel.Name = "priceRedCardLabel";
            this.priceRedCardLabel.Size = new System.Drawing.Size(228, 25);
            this.priceRedCardLabel.TabIndex = 2;
            this.priceRedCardLabel.Text = "Цена - червена карта";
            // 
            // operationsBox
            // 
            this.operationsBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.operationsBox.Controls.Add(this.progressBarExport);
            this.operationsBox.Controls.Add(this.ExportLabel);
            this.operationsBox.Controls.Add(this.KpdBtn);
            this.operationsBox.Controls.Add(this.countLabel);
            this.operationsBox.Controls.Add(this.CancelBtn);
            this.operationsBox.Controls.Add(this.ExportDataBtn);
            this.operationsBox.Controls.Add(this.GenerateAmperageBtn);
            this.operationsBox.Controls.Add(this.RotateCounterclockwiseBtn);
            this.operationsBox.Controls.Add(this.RotateClockwiseBtn);
            this.operationsBox.Controls.Add(this.txtRecords);
            this.operationsBox.Controls.Add(this.TotalNumber);
            this.operationsBox.Controls.Add(this.SearchBtn);
            this.operationsBox.Controls.Add(this.ViewBtn);
            this.operationsBox.Controls.Add(this.DeleteBtn);
            this.operationsBox.Controls.Add(this.AddBtn);
            this.operationsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operationsBox.Location = new System.Drawing.Point(12, 270);
            this.operationsBox.Name = "operationsBox";
            this.operationsBox.Size = new System.Drawing.Size(941, 199);
            this.operationsBox.TabIndex = 19;
            this.operationsBox.TabStop = false;
            this.operationsBox.Text = "Операции";
            // 
            // progressBarExport
            // 
            this.progressBarExport.Location = new System.Drawing.Point(540, 144);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(358, 23);
            this.progressBarExport.TabIndex = 16;
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportLabel.Location = new System.Drawing.Point(538, 176);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(129, 20);
            this.ExportLabel.TabIndex = 15;
            this.ExportLabel.Text = "Processing...0%";
            // 
            // KpdBtn
            // 
            this.KpdBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KpdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.KpdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KpdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KpdBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KpdBtn.Location = new System.Drawing.Point(351, 88);
            this.KpdBtn.Name = "KpdBtn";
            this.KpdBtn.Size = new System.Drawing.Size(131, 42);
            this.KpdBtn.TabIndex = 14;
            this.KpdBtn.Text = "КПД";
            this.KpdBtn.UseVisualStyleBackColor = false;
            this.KpdBtn.Click += new System.EventHandler(this.KpdBtn_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.ForeColor = System.Drawing.Color.Red;
            this.countLabel.Location = new System.Drawing.Point(130, 145);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 24);
            this.countLabel.TabIndex = 13;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelBtn.Location = new System.Drawing.Point(351, 32);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(131, 42);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Изчисти";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ExportDataBtn
            // 
            this.ExportDataBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExportDataBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.ExportDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportDataBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ExportDataBtn.Location = new System.Drawing.Point(746, 88);
            this.ExportDataBtn.Name = "ExportDataBtn";
            this.ExportDataBtn.Size = new System.Drawing.Size(152, 42);
            this.ExportDataBtn.TabIndex = 11;
            this.ExportDataBtn.Text = "Експорт";
            this.ExportDataBtn.UseVisualStyleBackColor = false;
            this.ExportDataBtn.Click += new System.EventHandler(this.ExportDataBtn_Click);
            // 
            // GenerateAmperageBtn
            // 
            this.GenerateAmperageBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenerateAmperageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.GenerateAmperageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateAmperageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateAmperageBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateAmperageBtn.Location = new System.Drawing.Point(746, 32);
            this.GenerateAmperageBtn.Name = "GenerateAmperageBtn";
            this.GenerateAmperageBtn.Size = new System.Drawing.Size(152, 40);
            this.GenerateAmperageBtn.TabIndex = 10;
            this.GenerateAmperageBtn.Text = "Произведи ток";
            this.GenerateAmperageBtn.UseVisualStyleBackColor = false;
            this.GenerateAmperageBtn.Click += new System.EventHandler(this.GenerateAmperageBtn_Click);
            // 
            // RotateCounterclockwiseBtn
            // 
            this.RotateCounterclockwiseBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RotateCounterclockwiseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.RotateCounterclockwiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateCounterclockwiseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateCounterclockwiseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotateCounterclockwiseBtn.Image = ((System.Drawing.Image)(resources.GetObject("RotateCounterclockwiseBtn.Image")));
            this.RotateCounterclockwiseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotateCounterclockwiseBtn.Location = new System.Drawing.Point(540, 88);
            this.RotateCounterclockwiseBtn.Name = "RotateCounterclockwiseBtn";
            this.RotateCounterclockwiseBtn.Size = new System.Drawing.Size(127, 42);
            this.RotateCounterclockwiseBtn.TabIndex = 9;
            this.RotateCounterclockwiseBtn.Text = "Завърти";
            this.RotateCounterclockwiseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RotateCounterclockwiseBtn.UseVisualStyleBackColor = false;
            this.RotateCounterclockwiseBtn.Click += new System.EventHandler(this.RotateCounterclockwiseBtn_Click);
            // 
            // RotateClockwiseBtn
            // 
            this.RotateClockwiseBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RotateClockwiseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.RotateClockwiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateClockwiseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateClockwiseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotateClockwiseBtn.Image = ((System.Drawing.Image)(resources.GetObject("RotateClockwiseBtn.Image")));
            this.RotateClockwiseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RotateClockwiseBtn.Location = new System.Drawing.Point(540, 30);
            this.RotateClockwiseBtn.Name = "RotateClockwiseBtn";
            this.RotateClockwiseBtn.Size = new System.Drawing.Size(127, 42);
            this.RotateClockwiseBtn.TabIndex = 8;
            this.RotateClockwiseBtn.Text = "Завърти";
            this.RotateClockwiseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RotateClockwiseBtn.UseVisualStyleBackColor = false;
            this.RotateClockwiseBtn.Click += new System.EventHandler(this.RotateClockwiseBtn_Click);
            // 
            // txtRecords
            // 
            this.txtRecords.AutoSize = true;
            this.txtRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRecords.ForeColor = System.Drawing.Color.Red;
            this.txtRecords.Location = new System.Drawing.Point(140, 106);
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.Size = new System.Drawing.Size(0, 24);
            this.txtRecords.TabIndex = 7;
            // 
            // TotalNumber
            // 
            this.TotalNumber.AutoSize = true;
            this.TotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalNumber.Location = new System.Drawing.Point(34, 145);
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.Size = new System.Drawing.Size(106, 24);
            this.TotalNumber.TabIndex = 6;
            this.TotalNumber.Text = "Общ брой";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBtn.Location = new System.Drawing.Point(35, 88);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(131, 42);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Търси";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewBtn.Location = new System.Drawing.Point(194, 31);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(131, 42);
            this.ViewBtn.TabIndex = 3;
            this.ViewBtn.Text = "Прегледай";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteBtn.Location = new System.Drawing.Point(194, 88);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(131, 42);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Изтрий";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddBtn.Location = new System.Drawing.Point(35, 31);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(131, 42);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добави";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(190)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(233)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(12, 475);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(941, 286);
            this.dataGridView.TabIndex = 12;
            this.dataGridView.DoubleClick += new System.EventHandler(this.DataGridView_DoubleClick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // StorageEngine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 765);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.operationsBox);
            this.Controls.Add(this.infoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StorageEngine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage Engine Info";
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.operationsBox.ResumeLayout(false);
            this.operationsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox chooseList;
        private System.Windows.Forms.TextBox AmperageTextbox;
        private System.Windows.Forms.TextBox RpmTextbox;
        private System.Windows.Forms.TextBox VoltageTextbox;
        private System.Windows.Forms.TextBox CapacityTextbox;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label amperageLabel;
        private System.Windows.Forms.TextBox PriceGreenTextbox;
        private System.Windows.Forms.TextBox PriceRedTextbox;
        private System.Windows.Forms.Label priceGreenCardLabel;
        private System.Windows.Forms.Label priceRedCardLabel;
        private System.Windows.Forms.GroupBox operationsBox;
        private System.Windows.Forms.Label txtRecords;
        private System.Windows.Forms.Label TotalNumber;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RotateClockwiseBtn;
        private System.Windows.Forms.Button RotateCounterclockwiseBtn;
        private System.Windows.Forms.Button ExportDataBtn;
        private System.Windows.Forms.Button GenerateAmperageBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button KpdBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.Label ExportLabel;
    }
}

