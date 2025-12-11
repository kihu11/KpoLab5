namespace Kpo.WinFormsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonAddToRation;
        private System.Windows.Forms.ListBox listBoxRation;
        private System.Windows.Forms.Label labelTotals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonAddToRation = new System.Windows.Forms.Button();
            this.listBoxRation = new System.Windows.Forms.ListBox();
            this.labelTotals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(12, 12);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(200, 420);
            this.listBoxCategories.TabIndex = 0;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(230, 12);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(300, 340);
            this.listBoxProducts.TabIndex = 1;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(230, 360);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeight.TabIndex = 2;
            this.textBoxWeight.Text = "100";
            // 
            // buttonAddToRation
            // 
            this.buttonAddToRation.Location = new System.Drawing.Point(350, 360);
            this.buttonAddToRation.Name = "buttonAddToRation";
            this.buttonAddToRation.Size = new System.Drawing.Size(180, 23);
            this.buttonAddToRation.TabIndex = 3;
            this.buttonAddToRation.Text = "Add to Ration";
            this.buttonAddToRation.UseVisualStyleBackColor = true;
            this.buttonAddToRation.Click += new System.EventHandler(this.buttonAddToRation_Click);
            // 
            // listBoxRation
            // 
            this.listBoxRation.FormattingEnabled = true;
            this.listBoxRation.ItemHeight = 16;
            this.listBoxRation.Location = new System.Drawing.Point(230, 390);
            this.listBoxRation.Name = "listBoxRation";
            this.listBoxRation.Size = new System.Drawing.Size(300, 84);
            this.listBoxRation.TabIndex = 4;
            // 
            // labelTotals
            // 
            this.labelTotals.AutoSize = true;
            this.labelTotals.Location = new System.Drawing.Point(230, 480);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(46, 17);
            this.labelTotals.TabIndex = 5;
            this.labelTotals.Text = "Totals";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.listBoxRation);
            this.Controls.Add(this.buttonAddToRation);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.listBoxCategories);
            this.Name = "MainForm";
            this.Text = "Daily Meal Planner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
