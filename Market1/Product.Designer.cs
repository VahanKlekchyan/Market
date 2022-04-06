
namespace Market1
{
    partial class Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductCode = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductGroup = new System.Windows.Forms.ComboBox();
            this.RegistrProdbutton = new System.Windows.Forms.Button();
            this.CloseProdbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Կոդ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Խումբ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Անվանում";
            // 
            // ProductCode
            // 
            this.ProductCode.Location = new System.Drawing.Point(119, 82);
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Size = new System.Drawing.Size(193, 20);
            this.ProductCode.TabIndex = 3;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(119, 285);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(193, 20);
            this.ProductName.TabIndex = 4;
            // 
            // ProductGroup
            // 
            this.ProductGroup.FormattingEnabled = true;
            this.ProductGroup.Location = new System.Drawing.Point(119, 170);
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.Size = new System.Drawing.Size(193, 21);
            this.ProductGroup.TabIndex = 5;
            // 
            // RegistrProdbutton
            // 
            this.RegistrProdbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrProdbutton.Location = new System.Drawing.Point(194, 371);
            this.RegistrProdbutton.Name = "RegistrProdbutton";
            this.RegistrProdbutton.Size = new System.Drawing.Size(102, 34);
            this.RegistrProdbutton.TabIndex = 6;
            this.RegistrProdbutton.Text = "Գրանցել";
            this.RegistrProdbutton.UseVisualStyleBackColor = true;
            this.RegistrProdbutton.Click += new System.EventHandler(this.Registrbutton_Click);
            // 
            // CloseProdbutton
            // 
            this.CloseProdbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseProdbutton.Location = new System.Drawing.Point(445, 371);
            this.CloseProdbutton.Name = "CloseProdbutton";
            this.CloseProdbutton.Size = new System.Drawing.Size(97, 34);
            this.CloseProdbutton.TabIndex = 7;
            this.CloseProdbutton.Text = "Ջնջել";
            this.CloseProdbutton.UseVisualStyleBackColor = true;
            this.CloseProdbutton.Click += new System.EventHandler(this.CloseProdbutton_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseProdbutton);
            this.Controls.Add(this.RegistrProdbutton);
            this.Controls.Add(this.ProductGroup);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Ապրանքներ անվանումների ցուցակ";
            this.Load += new System.EventHandler(this.Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ProductCode;
        public System.Windows.Forms.TextBox ProductName;
        public System.Windows.Forms.ComboBox ProductGroup;
        public System.Windows.Forms.Button RegistrProdbutton;
        public System.Windows.Forms.Button CloseProdbutton;
    }
}