namespace StorageEngine
{
    partial class CalculateKpd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateKpd));
            this.chooseLabel = new System.Windows.Forms.Label();
            this.chooseList = new System.Windows.Forms.ComboBox();
            this.IdЕngineLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CalculatePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CalculatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(40, 43);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(187, 24);
            this.chooseLabel.TabIndex = 21;
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
            "Dc"});
            this.chooseList.Location = new System.Drawing.Point(187, 34);
            this.chooseList.Margin = new System.Windows.Forms.Padding(4);
            this.chooseList.Name = "chooseList";
            this.chooseList.Size = new System.Drawing.Size(224, 33);
            this.chooseList.Sorted = true;
            this.chooseList.TabIndex = 22;
            // 
            // IdЕngineLabel
            // 
            this.IdЕngineLabel.AutoSize = true;
            this.IdЕngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdЕngineLabel.Location = new System.Drawing.Point(40, 105);
            this.IdЕngineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdЕngineLabel.Name = "IdЕngineLabel";
            this.IdЕngineLabel.Size = new System.Drawing.Size(150, 24);
            this.IdЕngineLabel.TabIndex = 23;
            this.IdЕngineLabel.Text = "Ид на двигател";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(187, 101);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(65, 28);
            this.IdTextbox.TabIndex = 24;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CalculateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CalculateBtn.Location = new System.Drawing.Point(44, 166);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(391, 52);
            this.CalculateBtn.TabIndex = 25;
            this.CalculateBtn.Text = "Изчисли КПД";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // CalculatePicture
            // 
            this.CalculatePicture.Image = ((System.Drawing.Image)(resources.GetObject("CalculatePicture.Image")));
            this.CalculatePicture.Location = new System.Drawing.Point(442, 22);
            this.CalculatePicture.Name = "CalculatePicture";
            this.CalculatePicture.Size = new System.Drawing.Size(337, 208);
            this.CalculatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CalculatePicture.TabIndex = 26;
            this.CalculatePicture.TabStop = false;
            // 
            // CalculateKpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(787, 235);
            this.Controls.Add(this.CalculatePicture);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.IdЕngineLabel);
            this.Controls.Add(this.chooseList);
            this.Controls.Add(this.chooseLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CalculateKpd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изчисляване на КПД";
            ((System.ComponentModel.ISupportInitialize)(this.CalculatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox chooseList;
        private System.Windows.Forms.Label IdЕngineLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.PictureBox CalculatePicture;
    }
}