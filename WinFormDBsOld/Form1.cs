using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDBsOld.ExperimentsDBDataSetTableAdapters;

namespace WinFormDBsOld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FillBy_Click(object sender, EventArgs e)
        {
            RefreshTable(tbBrands.Text);
        }

        private void RefreshTable(string brandName)
        {
            if(string.IsNullOrEmpty(brandName))
                return;

            try
            {
                this.dataTableBrandAndModelsTableAdapter.Fill(this.experimentsDBDataSet.DataTableBrandAndModels, tbBrands.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var brandId = textBox1.Text;
            var modelName = textBox2.Text;
            if (string.IsNullOrEmpty(brandId) || string.IsNullOrEmpty(modelName))
            {
                MessageBox.Show("Important values are empty.");
                return;
            }

            try
            {
                if (this.dataTableModelsAdapter == null)
                    this.dataTableModelsAdapter = new ModelsTableAdapter();

                if(long.TryParse(brandId, out var brandIdLong))
                {
                    this.dataTableModelsAdapter.InsertQuery(modelName, brandIdLong);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            RefreshTable(tbBrands.Text);
        }
    }
}
