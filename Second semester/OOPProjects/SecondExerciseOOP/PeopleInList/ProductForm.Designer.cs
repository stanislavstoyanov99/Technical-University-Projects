namespace PeopleInList
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameTxtbox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductPriceTxtbox = new System.Windows.Forms.TextBox();
            this.ProductSerialNumberLabel = new System.Windows.Forms.Label();
            this.ProductSerialNumberTxtbox = new System.Windows.Forms.TextBox();
            this.ProductAcceptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(44, 37);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(141, 20);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Име на продукт";
            // 
            // ProductNameTxtbox
            // 
            this.ProductNameTxtbox.Location = new System.Drawing.Point(48, 75);
            this.ProductNameTxtbox.Name = "ProductNameTxtbox";
            this.ProductNameTxtbox.Size = new System.Drawing.Size(472, 27);
            this.ProductNameTxtbox.TabIndex = 2;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(44, 123);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(52, 20);
            this.ProductPriceLabel.TabIndex = 3;
            this.ProductPriceLabel.Text = "Цена";
            // 
            // ProductPriceTxtbox
            // 
            this.ProductPriceTxtbox.Location = new System.Drawing.Point(48, 157);
            this.ProductPriceTxtbox.Name = "ProductPriceTxtbox";
            this.ProductPriceTxtbox.Size = new System.Drawing.Size(472, 27);
            this.ProductPriceTxtbox.TabIndex = 4;
            // 
            // ProductSerialNumberLabel
            // 
            this.ProductSerialNumberLabel.AutoSize = true;
            this.ProductSerialNumberLabel.Location = new System.Drawing.Point(44, 204);
            this.ProductSerialNumberLabel.Name = "ProductSerialNumberLabel";
            this.ProductSerialNumberLabel.Size = new System.Drawing.Size(128, 20);
            this.ProductSerialNumberLabel.TabIndex = 5;
            this.ProductSerialNumberLabel.Text = "Сериен номер";
            // 
            // ProductSerialNumberTxtbox
            // 
            this.ProductSerialNumberTxtbox.Location = new System.Drawing.Point(48, 240);
            this.ProductSerialNumberTxtbox.Name = "ProductSerialNumberTxtbox";
            this.ProductSerialNumberTxtbox.Size = new System.Drawing.Size(472, 27);
            this.ProductSerialNumberTxtbox.TabIndex = 6;
            // 
            // ProductAcceptBtn
            // 
            this.ProductAcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAcceptBtn.Location = new System.Drawing.Point(424, 292);
            this.ProductAcceptBtn.Name = "ProductAcceptBtn";
            this.ProductAcceptBtn.Size = new System.Drawing.Size(96, 38);
            this.ProductAcceptBtn.TabIndex = 7;
            this.ProductAcceptBtn.Text = "ОК";
            this.ProductAcceptBtn.UseVisualStyleBackColor = true;
            this.ProductAcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 358);
            this.Controls.Add(this.ProductAcceptBtn);
            this.Controls.Add(this.ProductSerialNumberTxtbox);
            this.Controls.Add(this.ProductSerialNumberLabel);
            this.Controls.Add(this.ProductPriceTxtbox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameTxtbox);
            this.Controls.Add(this.ProductNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameTxtbox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductPriceTxtbox;
        private System.Windows.Forms.Label ProductSerialNumberLabel;
        private System.Windows.Forms.TextBox ProductSerialNumberTxtbox;
        private System.Windows.Forms.Button ProductAcceptBtn;
    }
}