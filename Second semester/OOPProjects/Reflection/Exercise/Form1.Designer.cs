namespace Exercise
{
    partial class MainForm
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
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.secondListbox = new System.Windows.Forms.ListBox();
            this.thirdListbox = new System.Windows.Forms.ListBox();
            this.CreateObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(204, 465);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(114, 51);
            this.AcceptBtn.TabIndex = 0;
            this.AcceptBtn.Text = "Oтвори...";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(49, 38);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(259, 164);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // secondListbox
            // 
            this.secondListbox.FormattingEnabled = true;
            this.secondListbox.ItemHeight = 16;
            this.secondListbox.Location = new System.Drawing.Point(394, 38);
            this.secondListbox.Name = "secondListbox";
            this.secondListbox.Size = new System.Drawing.Size(259, 164);
            this.secondListbox.TabIndex = 2;
            this.secondListbox.SelectedIndexChanged += new System.EventHandler(this.secondListbox_SelectedIndexChanged);
            // 
            // thirdListbox
            // 
            this.thirdListbox.FormattingEnabled = true;
            this.thirdListbox.ItemHeight = 16;
            this.thirdListbox.Location = new System.Drawing.Point(204, 254);
            this.thirdListbox.Name = "thirdListbox";
            this.thirdListbox.Size = new System.Drawing.Size(259, 164);
            this.thirdListbox.TabIndex = 3;
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(349, 465);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(114, 51);
            this.CreateObject.TabIndex = 4;
            this.CreateObject.Text = "Обект";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 544);
            this.Controls.Add(this.CreateObject);
            this.Controls.Add(this.thirdListbox);
            this.Controls.Add(this.secondListbox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.AcceptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reflection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox secondListbox;
        private System.Windows.Forms.ListBox thirdListbox;
        private System.Windows.Forms.Button CreateObject;
    }
}

