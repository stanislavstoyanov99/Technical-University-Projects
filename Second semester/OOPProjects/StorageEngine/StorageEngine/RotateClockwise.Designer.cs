namespace StorageEngine
{
    partial class RotateClockwise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotateClockwise));
            this.RotateBtn = new System.Windows.Forms.Button();
            this.IdЕngineLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.VoltageAmount = new System.Windows.Forms.TextBox();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.chooseList = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RotateBtn
            // 
            this.RotateBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RotateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.RotateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotateBtn.Location = new System.Drawing.Point(28, 206);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(347, 65);
            this.RotateBtn.TabIndex = 12;
            this.RotateBtn.Text = "Завърти";
            this.RotateBtn.UseVisualStyleBackColor = false;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // IdЕngineLabel
            // 
            this.IdЕngineLabel.AutoSize = true;
            this.IdЕngineLabel.Location = new System.Drawing.Point(24, 99);
            this.IdЕngineLabel.Name = "IdЕngineLabel";
            this.IdЕngineLabel.Size = new System.Drawing.Size(150, 24);
            this.IdЕngineLabel.TabIndex = 16;
            this.IdЕngineLabel.Text = "Ид на двигател";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(195, 95);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(65, 28);
            this.IdTextbox.TabIndex = 17;
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Location = new System.Drawing.Point(24, 141);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(221, 24);
            this.voltageLabel.TabIndex = 18;
            this.voltageLabel.Text = "Въведете напрежение:";
            // 
            // VoltageAmount
            // 
            this.VoltageAmount.Location = new System.Drawing.Point(195, 137);
            this.VoltageAmount.Name = "VoltageAmount";
            this.VoltageAmount.Size = new System.Drawing.Size(65, 28);
            this.VoltageAmount.TabIndex = 19;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(24, 47);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(187, 24);
            this.chooseLabel.TabIndex = 20;
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
            this.chooseList.Location = new System.Drawing.Point(195, 38);
            this.chooseList.Name = "chooseList";
            this.chooseList.Size = new System.Drawing.Size(180, 33);
            this.chooseList.Sorted = true;
            this.chooseList.TabIndex = 21;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Image = global::StorageEngine.Properties.Resources.rotate_clockwise_image;
            this.pictureBox.Location = new System.Drawing.Point(458, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(306, 244);
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // RotateClockwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(772, 291);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.chooseList);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.VoltageAmount);
            this.Controls.Add(this.voltageLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.IdЕngineLabel);
            this.Controls.Add(this.RotateBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RotateClockwise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завъртане по часовниковата стрелка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RotateBtn;
        private System.Windows.Forms.Label IdЕngineLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.TextBox VoltageAmount;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox chooseList;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}