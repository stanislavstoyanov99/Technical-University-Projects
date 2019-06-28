namespace PeopleInList
{
    partial class PeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SearchTxtbox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.ItemHeight = 20;
            this.listBoxPeople.Location = new System.Drawing.Point(12, 76);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(476, 304);
            this.listBoxPeople.TabIndex = 3;
            this.listBoxPeople.DoubleClick += new System.EventHandler(this.listBoxPeople_DoubleClick);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(266, 398);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(98, 29);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(390, 398);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(98, 29);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SearchTxtbox
            // 
            this.SearchTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxtbox.Location = new System.Drawing.Point(12, 25);
            this.SearchTxtbox.Name = "SearchTxtbox";
            this.SearchTxtbox.Size = new System.Drawing.Size(352, 27);
            this.SearchTxtbox.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(390, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(98, 29);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ShowAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllBtn.Location = new System.Drawing.Point(143, 398);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(98, 29);
            this.ShowAllBtn.TabIndex = 8;
            this.ShowAllBtn.Text = "Show all";
            this.ShowAllBtn.UseVisualStyleBackColor = false;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(500, 439);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxtbox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.listBoxPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPeople;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox SearchTxtbox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ShowAllBtn;
    }
}

