
namespace Market1
{
    partial class Sales
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
            this.comboBox1ProductGroup = new System.Windows.Forms.ComboBox();
            this.comboBox2ProductName = new System.Windows.Forms.ComboBox();
            this.comboBox3Partners = new System.Windows.Forms.ComboBox();
            this.textBox1Hdm = new System.Windows.Forms.TextBox();
            this.textBox2Count = new System.Windows.Forms.TextBox();
            this.textBox3DiscountPrice = new System.Windows.Forms.TextBox();
            this.textBox4Price = new System.Windows.Forms.TextBox();
            this.textBox5Sum = new System.Windows.Forms.TextBox();
            this.textBox6DCountpersent = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1Sales = new System.Windows.Forms.DataGridView();
            this.button1Grancel = new System.Windows.Forms.Button();
            this.button2Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1ProductGroup
            // 
            this.comboBox1ProductGroup.FormattingEnabled = true;
            this.comboBox1ProductGroup.Location = new System.Drawing.Point(32, 30);
            this.comboBox1ProductGroup.Name = "comboBox1ProductGroup";
            this.comboBox1ProductGroup.Size = new System.Drawing.Size(168, 21);
            this.comboBox1ProductGroup.TabIndex = 0;
            this.comboBox1ProductGroup.TextChanged += new System.EventHandler(this.comboBox1ProductGroup_TextChanged);
            // 
            // comboBox2ProductName
            // 
            this.comboBox2ProductName.FormattingEnabled = true;
            this.comboBox2ProductName.Location = new System.Drawing.Point(32, 86);
            this.comboBox2ProductName.Name = "comboBox2ProductName";
            this.comboBox2ProductName.Size = new System.Drawing.Size(168, 21);
            this.comboBox2ProductName.TabIndex = 1;
            // 
            // comboBox3Partners
            // 
            this.comboBox3Partners.FormattingEnabled = true;
            this.comboBox3Partners.Location = new System.Drawing.Point(204, 157);
            this.comboBox3Partners.Name = "comboBox3Partners";
            this.comboBox3Partners.Size = new System.Drawing.Size(168, 21);
            this.comboBox3Partners.TabIndex = 2;
            this.comboBox3Partners.TextChanged += new System.EventHandler(this.comboBox3Partners_TextChanged);
            // 
            // textBox1Hdm
            // 
            this.textBox1Hdm.Location = new System.Drawing.Point(65, 157);
            this.textBox1Hdm.Name = "textBox1Hdm";
            this.textBox1Hdm.Size = new System.Drawing.Size(100, 20);
            this.textBox1Hdm.TabIndex = 3;
            // 
            // textBox2Count
            // 
            this.textBox2Count.Location = new System.Drawing.Point(222, 62);
            this.textBox2Count.Name = "textBox2Count";
            this.textBox2Count.Size = new System.Drawing.Size(74, 20);
            this.textBox2Count.TabIndex = 4;
            // 
            // textBox3DiscountPrice
            // 
            this.textBox3DiscountPrice.Location = new System.Drawing.Point(400, 62);
            this.textBox3DiscountPrice.Name = "textBox3DiscountPrice";
            this.textBox3DiscountPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox3DiscountPrice.TabIndex = 5;
            // 
            // textBox4Price
            // 
            this.textBox4Price.Location = new System.Drawing.Point(311, 62);
            this.textBox4Price.Name = "textBox4Price";
            this.textBox4Price.Size = new System.Drawing.Size(73, 20);
            this.textBox4Price.TabIndex = 6;
            // 
            // textBox5Sum
            // 
            this.textBox5Sum.Location = new System.Drawing.Point(507, 62);
            this.textBox5Sum.Name = "textBox5Sum";
            this.textBox5Sum.Size = new System.Drawing.Size(100, 20);
            this.textBox5Sum.TabIndex = 7;
            // 
            // textBox6DCountpersent
            // 
            this.textBox6DCountpersent.Location = new System.Drawing.Point(400, 158);
            this.textBox6DCountpersent.Name = "textBox6DCountpersent";
            this.textBox6DCountpersent.Size = new System.Drawing.Size(100, 20);
            this.textBox6DCountpersent.TabIndex = 8;
            this.textBox6DCountpersent.TextChanged += new System.EventHandler(this.textBox6DCountpersent_TextChanged);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(649, 90);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(111, 36);
            this.buttonADD.TabIndex = 9;
            this.buttonADD.Text = "Ավելացնել";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ապրանքի խումբ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ապրանքի Անվանում";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Կտրոնի N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Քանակ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Վաճառքի գին";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Զեղչված գին";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Գումար";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Գնորդ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Զեղչի %";
            // 
            // dataGridView1Sales
            // 
            this.dataGridView1Sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1Sales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Sales.Location = new System.Drawing.Point(3, 197);
            this.dataGridView1Sales.Name = "dataGridView1Sales";
            this.dataGridView1Sales.Size = new System.Drawing.Size(898, 220);
            this.dataGridView1Sales.TabIndex = 19;
            // 
            // button1Grancel
            // 
            this.button1Grancel.Location = new System.Drawing.Point(222, 444);
            this.button1Grancel.Name = "button1Grancel";
            this.button1Grancel.Size = new System.Drawing.Size(88, 27);
            this.button1Grancel.TabIndex = 20;
            this.button1Grancel.Text = "Գրանցել";
            this.button1Grancel.UseVisualStyleBackColor = true;
            this.button1Grancel.Click += new System.EventHandler(this.button1Grancel_Click);
            // 
            // button2Close
            // 
            this.button2Close.Location = new System.Drawing.Point(386, 444);
            this.button2Close.Name = "button2Close";
            this.button2Close.Size = new System.Drawing.Size(88, 27);
            this.button2Close.TabIndex = 21;
            this.button2Close.Text = "Փակել";
            this.button2Close.UseVisualStyleBackColor = true;
            this.button2Close.Click += new System.EventHandler(this.button2Close_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 486);
            this.Controls.Add(this.button2Close);
            this.Controls.Add(this.button1Grancel);
            this.Controls.Add(this.dataGridView1Sales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBox6DCountpersent);
            this.Controls.Add(this.textBox5Sum);
            this.Controls.Add(this.textBox4Price);
            this.Controls.Add(this.textBox3DiscountPrice);
            this.Controls.Add(this.textBox2Count);
            this.Controls.Add(this.textBox1Hdm);
            this.Controls.Add(this.comboBox3Partners);
            this.Controls.Add(this.comboBox2ProductName);
            this.Controls.Add(this.comboBox1ProductGroup);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1ProductGroup;
        private System.Windows.Forms.ComboBox comboBox2ProductName;
        private System.Windows.Forms.ComboBox comboBox3Partners;
        private System.Windows.Forms.TextBox textBox1Hdm;
        private System.Windows.Forms.TextBox textBox2Count;
        private System.Windows.Forms.TextBox textBox3DiscountPrice;
        private System.Windows.Forms.TextBox textBox4Price;
        private System.Windows.Forms.TextBox textBox5Sum;
        private System.Windows.Forms.TextBox textBox6DCountpersent;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1Sales;
        private System.Windows.Forms.Button button1Grancel;
        private System.Windows.Forms.Button button2Close;
    }
}