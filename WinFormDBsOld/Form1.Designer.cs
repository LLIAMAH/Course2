namespace WinFormDBsOld
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBrandAndModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.experimentsDBDataSet = new WinFormDBsOld.ExperimentsDBDataSet();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbBrands = new System.Windows.Forms.TextBox();
            this.FillBy = new System.Windows.Forms.Button();
            this.brandsTableAdapter = new WinFormDBsOld.ExperimentsDBDataSetTableAdapters.BrandsTableAdapter();
            this.dataTableBrandAndModelsTableAdapter = new WinFormDBsOld.ExperimentsDBDataSetTableAdapters.DataTableBrandAndModelsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBrandAndModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandIdDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelIdDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTableBrandAndModelsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 573);
            this.dataGridView1.TabIndex = 0;
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            this.brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            this.brandIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            this.modelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataTableBrandAndModelsBindingSource
            // 
            this.dataTableBrandAndModelsBindingSource.DataMember = "DataTableBrandAndModels";
            this.dataTableBrandAndModelsBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.experimentsDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // experimentsDBDataSet
            // 
            this.experimentsDBDataSet.DataSetName = "ExperimentsDBDataSet";
            this.experimentsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.bindingSource1;
            // 
            // tbBrands
            // 
            this.tbBrands.Location = new System.Drawing.Point(46, 19);
            this.tbBrands.Name = "tbBrands";
            this.tbBrands.Size = new System.Drawing.Size(305, 26);
            this.tbBrands.TabIndex = 1;
            // 
            // FillBy
            // 
            this.FillBy.Location = new System.Drawing.Point(357, 12);
            this.FillBy.Name = "FillBy";
            this.FillBy.Size = new System.Drawing.Size(155, 41);
            this.FillBy.TabIndex = 2;
            this.FillBy.Text = "button1";
            this.FillBy.UseVisualStyleBackColor = true;
            this.FillBy.Click += new System.EventHandler(this.FillBy_Click);
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableBrandAndModelsTableAdapter
            // 
            this.dataTableBrandAndModelsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1230, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1230, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1107, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "BraandID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1107, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1366, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add new Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 718);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FillBy);
            this.Controls.Add(this.tbBrands);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBrandAndModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experimentsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ExperimentsDBDataSet experimentsDBDataSet;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private ExperimentsDBDataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableBrandAndModelsBindingSource;
        private ExperimentsDBDataSetTableAdapters.DataTableBrandAndModelsTableAdapter dataTableBrandAndModelsTableAdapter;
        private ExperimentsDBDataSetTableAdapters.ModelsTableAdapter dataTableModelsAdapter;
        private System.Windows.Forms.TextBox tbBrands;
        private System.Windows.Forms.Button FillBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

