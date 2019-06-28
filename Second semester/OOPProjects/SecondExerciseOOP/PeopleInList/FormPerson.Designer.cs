namespace PeopleInList
{
    partial class FormPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerson));
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTxtbox = new System.Windows.Forms.TextBox();
            this.EgnLabel = new System.Windows.Forms.Label();
            this.EgnTxtbox = new System.Windows.Forms.TextBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.productsListbox = new System.Windows.Forms.ListBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(32, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Име";
            // 
            // NameTxtbox
            // 
            this.NameTxtbox.Location = new System.Drawing.Point(36, 80);
            this.NameTxtbox.Name = "NameTxtbox";
            this.NameTxtbox.Size = new System.Drawing.Size(472, 27);
            this.NameTxtbox.TabIndex = 1;
            // 
            // EgnLabel
            // 
            this.EgnLabel.AutoSize = true;
            this.EgnLabel.Location = new System.Drawing.Point(32, 126);
            this.EgnLabel.Name = "EgnLabel";
            this.EgnLabel.Size = new System.Drawing.Size(44, 20);
            this.EgnLabel.TabIndex = 2;
            this.EgnLabel.Text = "ЕГН";
            // 
            // EgnTxtbox
            // 
            this.EgnTxtbox.Location = new System.Drawing.Point(36, 159);
            this.EgnTxtbox.Name = "EgnTxtbox";
            this.EgnTxtbox.Size = new System.Drawing.Size(472, 27);
            this.EgnTxtbox.TabIndex = 3;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.Location = new System.Drawing.Point(412, 401);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(96, 38);
            this.AcceptBtn.TabIndex = 4;
            this.AcceptBtn.Text = "ОК";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(32, 206);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(91, 20);
            this.ProductsLabel.TabIndex = 5;
            this.ProductsLabel.Text = "Продукти";
            // 
            // productsListbox
            // 
            this.productsListbox.FormattingEnabled = true;
            this.productsListbox.ItemHeight = 20;
            this.productsListbox.Location = new System.Drawing.Point(36, 239);
            this.productsListbox.Name = "productsListbox";
            this.productsListbox.Size = new System.Drawing.Size(472, 144);
            this.productsListbox.TabIndex = 6;
            this.productsListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productsListbox_MouseDoubleClick);
            // 
            // AddProduct
            // 
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(218, 401);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(172, 38);
            this.AddProduct.TabIndex = 7;
            this.AddProduct.Text = "Добави продукт";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProduct.Location = new System.Drawing.Point(36, 401);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(165, 38);
            this.RemoveProduct.TabIndex = 8;
            this.RemoveProduct.Text = "Премахни продукт";
            this.RemoveProduct.UseVisualStyleBackColor = true;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 451);
            this.Controls.Add(this.RemoveProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.productsListbox);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.EgnTxtbox);
            this.Controls.Add(this.EgnLabel);
            this.Controls.Add(this.NameTxtbox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основно меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTxtbox;
        private System.Windows.Forms.Label EgnLabel;
        private System.Windows.Forms.TextBox EgnTxtbox;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.ListBox productsListbox;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button RemoveProduct;
    }
}