namespace OOPFinalProject
{
    partial class CheckPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPurchaseForm));
            this.firstDateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.backBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.purchasesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // firstDateLbl
            // 
            this.firstDateLbl.AutoSize = true;
            this.firstDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.firstDateLbl.Location = new System.Drawing.Point(49, 111);
            this.firstDateLbl.Name = "firstDateLbl";
            this.firstDateLbl.Size = new System.Drawing.Size(106, 13);
            this.firstDateLbl.TabIndex = 0;
            this.firstDateLbl.Text = "Choose a Start Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose an End Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 182);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.IndianRed;
            this.backBtn.Location = new System.Drawing.Point(12, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(197, 271);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 6;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // purchasesListView
            // 
            this.purchasesListView.BackColor = System.Drawing.SystemColors.MenuBar;
            this.purchasesListView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("purchasesListView.BackgroundImage")));
            this.purchasesListView.HideSelection = false;
            this.purchasesListView.Location = new System.Drawing.Point(419, 78);
            this.purchasesListView.Name = "purchasesListView";
            this.purchasesListView.Size = new System.Drawing.Size(357, 216);
            this.purchasesListView.TabIndex = 7;
            this.purchasesListView.UseCompatibleStateImageBehavior = false;
            this.purchasesListView.View = System.Windows.Forms.View.Details;
            // 
            // CheckPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchasesListView);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.firstDateLbl);
            this.Name = "CheckPurchaseForm";
            this.Text = "Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstDateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.ListView purchasesListView;
    }
}