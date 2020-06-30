using System.Windows.Forms;

namespace OOPFinalProject
{
    partial class BrowseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListView listView;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
            this.productView1 = new System.Windows.Forms.DataGridView();
            this.upcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oOPSTOREDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oOPSTOREDataSet = new OOPFinalProject.OOPSTOREDataSet();
            this.iTEMTableAdapter = new OOPFinalProject.OOPSTOREDataSetTableAdapters.ITEMTableAdapter();
            this.productLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPSTOREDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPSTOREDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productView1
            // 
            this.productView1.AllowUserToAddRows = false;
            this.productView1.AllowUserToDeleteRows = false;
            this.productView1.AllowUserToResizeColumns = false;
            this.productView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.upcDataGridViewTextBoxColumn,
            this.itemdescDataGridViewTextBoxColumn,
            this.itemqtyDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn});
            this.productView1.DataSource = this.iTEMBindingSource;
            this.productView1.Location = new System.Drawing.Point(204, 132);
            this.productView1.Name = "productView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productView1.RowHeadersVisible = false;
            this.productView1.Size = new System.Drawing.Size(405, 225);
            this.productView1.TabIndex = 0;
            // 
            // upcDataGridViewTextBoxColumn
            // 
            this.upcDataGridViewTextBoxColumn.DataPropertyName = "upc";
            this.upcDataGridViewTextBoxColumn.HeaderText = "UPC:";
            this.upcDataGridViewTextBoxColumn.Name = "upcDataGridViewTextBoxColumn";
            this.upcDataGridViewTextBoxColumn.ReadOnly = true;
            this.upcDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemdescDataGridViewTextBoxColumn
            // 
            this.itemdescDataGridViewTextBoxColumn.DataPropertyName = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.HeaderText = "Item:";
            this.itemdescDataGridViewTextBoxColumn.Name = "itemdescDataGridViewTextBoxColumn";
            this.itemdescDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itemqtyDataGridViewTextBoxColumn
            // 
            this.itemqtyDataGridViewTextBoxColumn.DataPropertyName = "item_qty";
            this.itemqtyDataGridViewTextBoxColumn.HeaderText = "Stock:";
            this.itemqtyDataGridViewTextBoxColumn.Name = "itemqtyDataGridViewTextBoxColumn";
            this.itemqtyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.itempriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "Price:";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itempriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // iTEMBindingSource
            // 
            this.iTEMBindingSource.DataMember = "ITEM";
            this.iTEMBindingSource.DataSource = this.oOPSTOREDataSetBindingSource;
            // 
            // oOPSTOREDataSetBindingSource
            // 
            this.oOPSTOREDataSetBindingSource.DataSource = this.oOPSTOREDataSet;
            this.oOPSTOREDataSetBindingSource.Position = 0;
            // 
            // oOPSTOREDataSet
            // 
            this.oOPSTOREDataSet.DataSetName = "OOPSTOREDataSet";
            this.oOPSTOREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMTableAdapter
            // 
            this.iTEMTableAdapter.ClearBeforeFill = true;
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.BackColor = System.Drawing.Color.Transparent;
            this.productLbl.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLbl.Location = new System.Drawing.Point(335, 51);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(163, 43);
            this.productLbl.TabIndex = 1;
            this.productLbl.Text = "Products:";
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
            // BrowseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.productView1);
            this.Name = "BrowseForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.BrowseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPSTOREDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPSTOREDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView productView1;
        private BindingSource oOPSTOREDataSetBindingSource;
        private OOPSTOREDataSet oOPSTOREDataSet;
        private BindingSource iTEMBindingSource;
        private OOPSTOREDataSetTableAdapters.ITEMTableAdapter iTEMTableAdapter;
        private DataGridViewTextBoxColumn upcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemdescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemqtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private Label productLbl;
        private Button backBtn;
    }
}