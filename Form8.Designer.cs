namespace OOPFinalProject
{
    partial class CheckPurchaseByPriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPurchaseByPriceForm));
            this.lowPriceLbl = new System.Windows.Forms.Label();
            this.highPriceLbl = new System.Windows.Forms.Label();
            this.lowestPriceText = new System.Windows.Forms.TextBox();
            this.highestPriceText = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.purchasesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lowPriceLbl
            // 
            this.lowPriceLbl.AutoSize = true;
            this.lowPriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.lowPriceLbl.Location = new System.Drawing.Point(70, 109);
            this.lowPriceLbl.Name = "lowPriceLbl";
            this.lowPriceLbl.Size = new System.Drawing.Size(70, 13);
            this.lowPriceLbl.TabIndex = 0;
            this.lowPriceLbl.Text = "Lowest price:";
            // 
            // highPriceLbl
            // 
            this.highPriceLbl.AutoSize = true;
            this.highPriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.highPriceLbl.Location = new System.Drawing.Point(70, 197);
            this.highPriceLbl.Name = "highPriceLbl";
            this.highPriceLbl.Size = new System.Drawing.Size(72, 13);
            this.highPriceLbl.TabIndex = 1;
            this.highPriceLbl.Text = "Highest price:";
            // 
            // lowestPriceText
            // 
            this.lowestPriceText.Location = new System.Drawing.Point(217, 102);
            this.lowestPriceText.Name = "lowestPriceText";
            this.lowestPriceText.Size = new System.Drawing.Size(100, 20);
            this.lowestPriceText.TabIndex = 2;
            // 
            // highestPriceText
            // 
            this.highestPriceText.Location = new System.Drawing.Point(217, 194);
            this.highestPriceText.Name = "highestPriceText";
            this.highestPriceText.Size = new System.Drawing.Size(100, 20);
            this.highestPriceText.TabIndex = 3;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(274, 298);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.IndianRed;
            this.back.Location = new System.Drawing.Point(12, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // purchasesListView
            // 
            this.purchasesListView.BackColor = System.Drawing.SystemColors.MenuBar;
            this.purchasesListView.HideSelection = false;
            this.purchasesListView.Location = new System.Drawing.Point(394, 84);
            this.purchasesListView.Name = "purchasesListView";
            this.purchasesListView.Size = new System.Drawing.Size(394, 211);
            this.purchasesListView.TabIndex = 7;
            this.purchasesListView.UseCompatibleStateImageBehavior = false;
            this.purchasesListView.View = System.Windows.Forms.View.Details;
            // 
            // CheckPurchaseByPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.highestPriceText);
            this.Controls.Add(this.lowestPriceText);
            this.Controls.Add(this.highPriceLbl);
            this.Controls.Add(this.lowPriceLbl);
            this.Controls.Add(this.purchasesListView);
            this.Name = "CheckPurchaseByPriceForm";
            this.Text = "Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lowPriceLbl;
        private System.Windows.Forms.Label highPriceLbl;
        private System.Windows.Forms.TextBox lowestPriceText;
        private System.Windows.Forms.TextBox highestPriceText;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListView purchasesListView;
    }
}