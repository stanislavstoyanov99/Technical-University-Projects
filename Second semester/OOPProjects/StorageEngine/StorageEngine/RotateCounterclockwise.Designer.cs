namespace StorageEngine
{
    partial class RotateCounterclockwise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotateCounterclockwise));
            this.chooseLabel = new System.Windows.Forms.Label();
            this.IdЕngineLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.VoltageAmount = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.chooseList = new System.Windows.Forms.ComboBox();
            this.RotateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(27, 40);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(187, 24);
            this.chooseLabel.TabIndex = 21;
            this.chooseLabel.Text = "Избери двигател:";
            // 
            // IdЕngineLabel
            // 
            this.IdЕngineLabel.AutoSize = true;
            this.IdЕngineLabel.Location = new System.Drawing.Point(26, 87);
            this.IdЕngineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdЕngineLabel.Name = "IdЕngineLabel";
            this.IdЕngineLabel.Size = new System.Drawing.Size(150, 24);
            this.IdЕngineLabel.TabIndex = 23;
            this.IdЕngineLabel.Text = "Ид на двигател";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(192, 83);
            this.IdTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(55, 28);
            this.IdTextbox.TabIndex = 24;
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Location = new System.Drawing.Point(26, 136);
            this.voltageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(221, 24);
            this.voltageLabel.TabIndex = 25;
            this.voltageLabel.Text = "Въведете напрежение:";
            // 
            // VoltageAmount
            // 
            this.VoltageAmount.Location = new System.Drawing.Point(192, 132);
            this.VoltageAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VoltageAmount.Name = "VoltageAmount";
            this.VoltageAmount.Size = new System.Drawing.Size(55, 28);
            this.VoltageAmount.TabIndex = 26;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Image = global::StorageEngine.Properties.Resources.rotate_counterclockwise_image_png;
            this.pictureBox.Location = new System.Drawing.Point(430, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(306, 244);
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
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
            this.chooseList.Location = new System.Drawing.Point(192, 31);
            this.chooseList.Name = "chooseList";
            this.chooseList.Size = new System.Drawing.Size(180, 33);
            this.chooseList.Sorted = true;
            this.chooseList.TabIndex = 29;
            // 
            // RotateBtn
            // 
            this.RotateBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RotateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.RotateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RotateBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RotateBtn.Location = new System.Drawing.Point(31, 202);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(347, 65);
            this.RotateBtn.TabIndex = 30;
            this.RotateBtn.Text = "Завърти";
            this.RotateBtn.UseVisualStyleBackColor = false;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // RotateCounterclockwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(772, 291);
            this.Controls.Add(this.RotateBtn);
            this.Controls.Add(this.chooseList);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.VoltageAmount);
            this.Controls.Add(this.voltageLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.IdЕngineLabel);
            this.Controls.Add(this.chooseLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RotateCounterclockwise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завъртане обратно на часовниковата стрелка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label IdЕngineLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.TextBox VoltageAmount;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox chooseList;
        private System.Windows.Forms.Button RotateBtn;
    }
}