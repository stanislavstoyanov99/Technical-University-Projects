namespace StorageEngine
{
    partial class GenerateEnergy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateEnergy));
            this.GenerateAmperageBtn = new System.Windows.Forms.Button();
            this.RpmAmount = new System.Windows.Forms.TextBox();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.IdGeneratorLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ProcessingStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateAmperageBtn
            // 
            this.GenerateAmperageBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenerateAmperageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.GenerateAmperageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateAmperageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateAmperageBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateAmperageBtn.Location = new System.Drawing.Point(92, 107);
            this.GenerateAmperageBtn.Name = "GenerateAmperageBtn";
            this.GenerateAmperageBtn.Size = new System.Drawing.Size(83, 40);
            this.GenerateAmperageBtn.TabIndex = 11;
            this.GenerateAmperageBtn.Text = "Старт";
            this.GenerateAmperageBtn.UseVisualStyleBackColor = false;
            this.GenerateAmperageBtn.Click += new System.EventHandler(this.GenerateAmperageBtn_Click);
            // 
            // RpmAmount
            // 
            this.RpmAmount.Location = new System.Drawing.Point(166, 67);
            this.RpmAmount.Name = "RpmAmount";
            this.RpmAmount.Size = new System.Drawing.Size(65, 28);
            this.RpmAmount.TabIndex = 12;
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.Location = new System.Drawing.Point(14, 70);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(185, 24);
            this.rpmLabel.TabIndex = 13;
            this.rpmLabel.Text = "Въведете обороти:";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(166, 33);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(65, 28);
            this.IdTextbox.TabIndex = 14;
            // 
            // IdGeneratorLabel
            // 
            this.IdGeneratorLabel.AutoSize = true;
            this.IdGeneratorLabel.Location = new System.Drawing.Point(14, 34);
            this.IdGeneratorLabel.Name = "IdGeneratorLabel";
            this.IdGeneratorLabel.Size = new System.Drawing.Size(161, 24);
            this.IdGeneratorLabel.TabIndex = 15;
            this.IdGeneratorLabel.Text = "Ид на генератор";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(18, 173);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(213, 30);
            this.ProgressBar.TabIndex = 16;
            // 
            // ProcessingStatus
            // 
            this.ProcessingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessingStatus.Location = new System.Drawing.Point(18, 150);
            this.ProcessingStatus.Name = "ProcessingStatus";
            this.ProcessingStatus.Size = new System.Drawing.Size(213, 20);
            this.ProcessingStatus.TabIndex = 17;
            this.ProcessingStatus.Text = "Обработване...0%";
            this.ProcessingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateEnergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(268, 225);
            this.Controls.Add(this.ProcessingStatus);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.IdGeneratorLabel);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.RpmAmount);
            this.Controls.Add(this.GenerateAmperageBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GenerateEnergy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Произведи ток";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateAmperageBtn;
        private System.Windows.Forms.TextBox RpmAmount;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label IdGeneratorLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label ProcessingStatus;
    }
}