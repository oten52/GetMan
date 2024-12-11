using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OtenTool.PostmanCore;
using OtenTool.PostmanCore.Constants;
using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Dtos;
using OtenTool.PostmanCore.Extentions;
using OtenTool.PostmanCore.Services.Concretes;
using OtenTool.PostmanCore.Services.Interfaces;

namespace OtenTool.PostmanCoreCore
{
    public partial class frmMain : Form
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;
        public frmMain()
        {

            var scope = Program.ServiceProvider.CreateScope();


            _projectService = scope.ServiceProvider.GetRequiredService<IProjectService>();
            _mapper = scope.ServiceProvider.GetRequiredService<IMapper>();


            InitializeComponent();
            this.ToDefaultFormSettings();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (PostmanContext context = new PostmanContext())

                if (context.Database.CanConnect())
                {
                    tssDatabase.Text = $"{context.Database.GetDbConnection().DataSource};{context.Database.GetDbConnection().Database}";
                    tssDatabase.BackColor = Color.Green;
                }
                else
                {
                    tssDatabase.Text = "Db Not Found";
                    tssDatabase.BackColor = Color.Red;
                }
            tssUser.Text = CacheConstants.LoginUser?.UserName;

            InitProjectsAsync();
        }

        public async Task<bool> InitProjectsAsync()
        {
            await InitGridAsync();

            return true;
        }
        public async Task<bool> InitGridAsync()
        {
            dgvProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProject.Rows.Clear();
            dgvProject.Columns.Clear();

            dgvProject.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProjectId",
                HeaderText = "Id",

            });

            dgvProject.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProjectName",
                HeaderText = "Project Name",

            });

            var list = await _projectService.GetProjectListAsync(CacheConstants.LoginUser.Id);

            var willShowList = _mapper.Map<List<ProjectViewDto>>(list);

            foreach (var project in willShowList)
            {
                dgvProject.Rows.Add(project.ProjectId, project.ProjectName);
            }

            return true;
        }

        private void tssDatabase_Click(object sender, EventArgs e)
        {
            using (PostmanContext context = new PostmanContext())

                if (context.Database.CanConnect())
                {
                    tssDatabase.Text = $"{context.Database.GetDbConnection().DataSource};{context.Database.GetDbConnection().Database}";
                    tssDatabase.BackColor = Color.Green;
                }
                else
                {
                    tssDatabase.Text = "Db Not Found";
                    tssDatabase.BackColor = Color.Red;
                }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitProjectsAsync();
        }

        private void dgvProject_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProject.SelectedRows != null && dgvProject.SelectedRows.Count > 0)
            {
                new frmPostman((int)dgvProject.SelectedRows[0].Cells[0].Value).Show();
            }
        }
    }
}
