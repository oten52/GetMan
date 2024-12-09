using Microsoft.Extensions.DependencyInjection;
using OtenTool.PostmanCore.Models;
using OtenTool.PostmanCore.Services.Interfaces;
using OtenTool.PostmanCoreCore;

namespace OtenTool.PostmanCore
{
    public partial class frmPostman : Form
    {
        private readonly int _projectId;
        private readonly ITreeItemService _treeItemService;
        private readonly IRequestItemService _requestItemService;
        public frmPostman(int projectId)
        {
            _projectId = projectId;

            var scope = Program.ServiceProvider.CreateScope();

            _treeItemService = scope.ServiceProvider.GetRequiredService<ITreeItemService>();
            _requestItemService = scope.ServiceProvider.GetRequiredService<IRequestItemService>();

            InitializeComponent();
        }

        private void frmPostman_Load(object sender, EventArgs e)
        {
            InitPostmanAsync();
            //panel1.Controls.Add(new Postman2() { Dock = DockStyle.Fill });

        }

        public async Task<bool> InitPostmanAsync()
        {
            await InitTreeViewAsync();

            return true;
        }
        public async Task<bool> InitTreeViewAsync()
        {
            var list = await _treeItemService.GetTreeItemsAsync(_projectId);

            var parrentList = list.Where(x => x.ParentId == null).ToList();

            treeView1.Nodes.Clear();

            foreach (var item in parrentList)
            {
                TreeNode treeNode = new TreeNode()
                {
                    Text = item.Name,
                    Tag = item
                };
                RecursiveFunc(treeNode, list, item.Id);

                treeView1.Nodes.Add(treeNode);

            }
            return true;
        }

        public void RecursiveFunc(TreeNode treeNode, List<tTreeItem> treeItems, int parentId)
        {
            foreach (var item in treeItems.Where(x => x.ParentId == parentId))
            {

                TreeNode treeNode2 = new TreeNode()
                {
                    Text = item.Name,
                    Tag = item,
                };

                RecursiveFunc(treeNode2, treeItems, item.Id);

                treeNode.Nodes.Add(treeNode2);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private async void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView tree = (TreeView)sender;

            if (tree.SelectedNode!=null)
            {
                tTreeItem treeItem = (tTreeItem)tree.SelectedNode.Tag;

                panel1.Controls.Clear();

                if (treeItem.IsRequest)
                {
                    var res = await _requestItemService.GetRequestItemByIdAsync(treeItem.Id);

                    res ??= new tRequestItem();

                    Postman2 postman = new Postman2(ref res) { Dock = DockStyle.Fill };

                    panel1.Controls.Add(postman);
                }

            }
        }
    }
}
