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
    }
}
