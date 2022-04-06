
namespace Market1
{
    partial class Report
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
            this.dataGridView1Rep = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1ST = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1ShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Rep)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1Rep
            // 
            this.dataGridView1Rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Rep.Location = new System.Drawing.Point(-1, 83);
            this.dataGridView1Rep.Name = "dataGridView1Rep";
            this.dataGridView1Rep.Size = new System.Drawing.Size(799, 364);
            this.dataGridView1Rep.TabIndex = 0;
            // 
            // dateTimePicker1ST
            // 
            this.dateTimePicker1ST.Location = new System.Drawing.Point(152, 28);
            this.dateTimePicker1ST.Name = "dateTimePicker1ST";
            this.dateTimePicker1ST.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1ST.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(304, 29);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(128, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ֆիլտր";
            // 
            // button1ShowReport
            // 
            this.button1ShowReport.Location = new System.Drawing.Point(478, 29);
            this.button1ShowReport.Name = "button1ShowReport";
            this.button1ShowReport.Size = new System.Drawing.Size(89, 24);
            this.button1ShowReport.TabIndex = 4;
            this.button1ShowReport.Text = "Բեռնել";
            this.button1ShowReport.UseVisualStyleBackColor = true;
            this.button1ShowReport.Click += new System.EventHandler(this.button1ShowReport_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1ShowReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePicker1ST);
            this.Controls.Add(this.dataGridView1Rep);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1Rep;
        private System.Windows.Forms.DateTimePicker dateTimePicker1ST;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1ShowReport;
    }
}