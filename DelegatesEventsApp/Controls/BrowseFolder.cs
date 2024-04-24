namespace DelegatesEventsApp.Controls
{
    public partial class BrowseFolder : UserControl
    {
        public event EventHandler<IList<TreeNode>> OnFilesFiltered;

        public BrowseFolder()
        {
            InitializeComponent();
        }

        private void bnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdBrowse.ShowDialog() == DialogResult.OK)
            {
                tbFolderPath.Text = fbdBrowse.SelectedPath;
                ProcessFiles(tbFolderPath.Text);
            }
        }

        private void ProcessFiles(string path)
        {
            var dir = new DirectoryInfo(path);
            var list = new List<TreeNode>();
            foreach (var directoryInfo in dir.GetDirectories())
            {
                list.AddRange(directoryInfo.GetFiles().Select(o => new TreeNode(o.Name)).ToArray());
            }

            list.AddRange(dir.GetFiles().Select(o => new TreeNode(o.Name)).ToArray());

            tvBooks.Nodes.AddRange(list.ToArray());
            this.OnFilesFiltered?.Invoke(this, list);
        }
    }
}
