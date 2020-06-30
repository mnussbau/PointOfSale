namespace OOPFinalProject
{
    partial class BalancesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalancesForm));
            this.checkBalanceLbl = new System.Windows.Forms.Label();
            this.giveABalanceLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.amtLbl = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.amtText = new System.Windows.Forms.TextBox();
            this.makePaymentLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBalanceLbl
            // 
            this.checkBalanceLbl.AutoSize = true;
            this.checkBalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.checkBalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceLbl.Location = new System.Drawing.Point(273, 35);
            this.checkBalanceLbl.Name = "checkBalanceLbl";
            this.checkBalanceLbl.Size = new System.Drawing.Size(274, 39);
            this.checkBalanceLbl.TabIndex = 0;
            this.checkBalanceLbl.Text = "Check Balance:";
            // 
            // giveABalanceLbl
            // 
            this.giveABalanceLbl.AutoSize = true;
            this.giveABalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.giveABalanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveABalanceLbl.Location = new System.Drawing.Point(151, 136);
            this.giveABalanceLbl.Name = "giveABalanceLbl";
            this.giveABalanceLbl.Size = new System.Drawing.Size(174, 25);
            this.giveABalanceLbl.TabIndex = 1;
            this.giveABalanceLbl.Text = "Your balance is: ";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.IndianRed;
            this.backBtn.Location = new System.Drawing.Point(12, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // amtLbl
            // 
            this.amtLbl.AutoSize = true;
            this.amtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLbl.Location = new System.Drawing.Point(331, 136);
            this.amtLbl.Name = "amtLbl";
            this.amtLbl.Size = new System.Drawing.Size(0, 24);
            this.amtLbl.TabIndex = 3;
            this.amtLbl.BackColor = System.Drawing.Color.Transparent;

            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(488, 291);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(108, 42);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "Make Payment";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // amtText
            // 
            this.amtText.Location = new System.Drawing.Point(335, 303);
            this.amtText.Name = "amtText";
            this.amtText.Size = new System.Drawing.Size(100, 20);
            this.amtText.TabIndex = 5;
            
            // 
            // makePaymentLbl
            // 
            this.makePaymentLbl.AutoSize = true;
            this.makePaymentLbl.BackColor = System.Drawing.Color.Transparent;
            this.makePaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePaymentLbl.Location = new System.Drawing.Point(145, 297);
            this.makePaymentLbl.Name = "makePaymentLbl";
            this.makePaymentLbl.Size = new System.Drawing.Size(148, 25);
            this.makePaymentLbl.TabIndex = 6;
            this.makePaymentLbl.Text = "Enter Amount:";
            // 
            // BalancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.makePaymentLbl);
            this.Controls.Add(this.amtText);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.amtLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.giveABalanceLbl);
            this.Controls.Add(this.checkBalanceLbl);
            this.Name = "BalancesForm";
            this.Text = "Check Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkBalanceLbl;
        private System.Windows.Forms.Label giveABalanceLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label amtLbl;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.TextBox amtText;
        private System.Windows.Forms.Label makePaymentLbl;
    }
}