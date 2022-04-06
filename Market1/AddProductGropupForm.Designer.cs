
namespace Market1
{
    partial class AddProductGropupForm
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
            this.Codetext = new System.Windows.Forms.TextBox();
            this.GroupNametext = new System.Windows.Forms.TextBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.PrGroupLabel = new System.Windows.Forms.Label();
            this.PrGroupNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Codetext
            // 
            this.Codetext.Location = new System.Drawing.Point(128, 109);
            this.Codetext.Name = "Codetext";
            this.Codetext.Size = new System.Drawing.Size(156, 20);
            this.Codetext.TabIndex = 2;
            // 
            // GroupNametext
            // 
            this.GroupNametext.Location = new System.Drawing.Point(128, 217);
            this.GroupNametext.Name = "GroupNametext";
            this.GroupNametext.Size = new System.Drawing.Size(156, 20);
            this.GroupNametext.TabIndex = 3;
            // 
            // ADDbutton
            // 
            this.ADDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbutton.Location = new System.Drawing.Point(234, 348);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(85, 30);
            this.ADDbutton.TabIndex = 4;
            this.ADDbutton.Text = "Գրանցել";
            this.ADDbutton.UseVisualStyleBackColor = true;
            this.ADDbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(478, 348);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(85, 30);
            this.Deletebutton.TabIndex = 5;
            this.Deletebutton.Text = "Ջնջել";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // PrGroupLabel
            // 
            this.PrGroupLabel.AutoSize = true;
            this.PrGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrGroupLabel.Location = new System.Drawing.Point(125, 69);
            this.PrGroupLabel.Name = "PrGroupLabel";
            this.PrGroupLabel.Size = new System.Drawing.Size(35, 16);
            this.PrGroupLabel.TabIndex = 0;
            this.PrGroupLabel.Text = "Կոդ";
            // 
            // PrGroupNameLabel
            // 
            this.PrGroupNameLabel.AutoSize = true;
            this.PrGroupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrGroupNameLabel.Location = new System.Drawing.Point(125, 149);
            this.PrGroupNameLabel.Name = "PrGroupNameLabel";
            this.PrGroupNameLabel.Size = new System.Drawing.Size(78, 16);
            this.PrGroupNameLabel.TabIndex = 1;
            this.PrGroupNameLabel.Text = "Անվանում";
            // 
            // AddProductGropupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.ADDbutton);
            this.Controls.Add(this.GroupNametext);
            this.Controls.Add(this.Codetext);
            this.Controls.Add(this.PrGroupNameLabel);
            this.Controls.Add(this.PrGroupLabel);
            this.Name = "AddProductGropupForm";
            this.Text = "AddProductGropupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Codetext;
        public System.Windows.Forms.TextBox GroupNametext;
        public System.Windows.Forms.Button ADDbutton;
        public System.Windows.Forms.Button Deletebutton;
        public System.Windows.Forms.Label PrGroupLabel;
        public System.Windows.Forms.Label PrGroupNameLabel;
    }
}