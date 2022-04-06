
namespace Market1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProducGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.DirectoryToolStripMenuItem,
            this.IncomeToolStripMenuItem,
            this.SalesToolStripMenuItem,
            this.WarehouseToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.StartToolStripMenuItem.Text = "Սկիզբ";
            // 
            // DirectoryToolStripMenuItem
            // 
            this.DirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProducGroupToolStripMenuItem,
            this.ProductNameToolStripMenuItem,
            this.BuyerToolStripMenuItem});
            this.DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem";
            this.DirectoryToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.DirectoryToolStripMenuItem.Text = "Տեղեկատուներ";
            // 
            // ProducGroupToolStripMenuItem
            // 
            this.ProducGroupToolStripMenuItem.Name = "ProducGroupToolStripMenuItem";
            this.ProducGroupToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ProducGroupToolStripMenuItem.Text = "Ապրանքների խմբեր";
            this.ProducGroupToolStripMenuItem.Click += new System.EventHandler(this.ProducGroupToolStripMenuItem_Click);
            // 
            // ProductNameToolStripMenuItem
            // 
            this.ProductNameToolStripMenuItem.Name = "ProductNameToolStripMenuItem";
            this.ProductNameToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ProductNameToolStripMenuItem.Text = "Ապրանքների անվանում";
            this.ProductNameToolStripMenuItem.Click += new System.EventHandler(this.ProductNameToolStripMenuItem_Click);
            // 
            // BuyerToolStripMenuItem
            // 
            this.BuyerToolStripMenuItem.Name = "BuyerToolStripMenuItem";
            this.BuyerToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.BuyerToolStripMenuItem.Text = "Գործընկերներ";
            this.BuyerToolStripMenuItem.Click += new System.EventHandler(this.BuyerToolStripMenuItem_Click);
            // 
            // IncomeToolStripMenuItem
            // 
            this.IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem";
            this.IncomeToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.IncomeToolStripMenuItem.Text = "Ապրանքների մուտք";
            this.IncomeToolStripMenuItem.Click += new System.EventHandler(this.IncomeToolStripMenuItem_Click);
            // 
            // SalesToolStripMenuItem
            // 
            this.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem";
            this.SalesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.SalesToolStripMenuItem.Text = "Վաճառք";
            this.SalesToolStripMenuItem.Click += new System.EventHandler(this.SalesToolStripMenuItem_Click);
            // 
            // WarehouseToolStripMenuItem
            // 
            this.WarehouseToolStripMenuItem.Name = "WarehouseToolStripMenuItem";
            this.WarehouseToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.WarehouseToolStripMenuItem.Text = "Պահեստ";
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.ReportToolStripMenuItem.Text = "Հաշվետվություն";
            this.ReportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.HelpToolStripMenuItem.Text = "Օգնություն";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Խանութի ծրագիր";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProducGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

