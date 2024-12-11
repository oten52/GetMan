using OtenTool.PostmanCore.Dtos;
using OtenTool.PostmanCore.Extentions;
using OtenTool.PostmanCore.Contexts;
using Microsoft.EntityFrameworkCore;
using OtenTool.PostmanCore.Services.Concretes;

namespace OtenTool.PostmanCore.Forms
{
    public partial class frmLogin : Form
    {
        private readonly UserService _userService;
        private int retryCount = 3;
        public frmLogin()
        {
            InitializeComponent();
            this.ToDefaultFormSettings();

            _userService = new();
        }

        private void frmLogin_Load(object sender, EventArgs e)
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            retryCount--;

            if (retryCount == 0)
            {
                this.DialogResult = DialogResult.Retry;
            }

            this.Enabled = false;

            var resLogin = await _userService.LoginAsync(new UserLoginDto(txtUserName.Text.Trim(), txtPassword.Text.Trim()));

            if (resLogin)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Enabled = true;
            }
        }
    }
}
