using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class FSomeData : Form
    {
        private SomeDataTransfer _data;

        public FSomeData()
        {
            InitializeComponent();
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            var title = tbTitle.Text;
            var genre = cbGenre.SelectedItem as string;

            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre))
                return;

            this._data = new SomeDataTransfer()
            {
                Title = title,
                Genre = genre
            };


            DialogResult = DialogResult.OK;
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public SomeDataTransfer GetData()
        {
            return this._data;
        }
    }

    public class SomeDataTransfer
    {
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
