namespace DelegatesEventsApp
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            bnMoveTo.Enabled = false;
            this.bfSource.OnFilesFiltered += BfSourceOnOnFilesFiltered;
        }

        private void BfSourceOnOnFilesFiltered(object? sender, IList<TreeNode> e)
        {
            bnMoveTo.Enabled = true;
        }

        private void bfDestination_OnFilesFiltered(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void browseFolder1_OnFilesFiltered(object sender, IList<TreeNode> e)
        {

        }
    }
}
