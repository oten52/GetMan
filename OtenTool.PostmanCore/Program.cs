using Microsoft.Extensions.DependencyInjection;
using OtenTool.PostmanCore;
using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Forms;
using OtenTool.PostmanCore.Mappings.ProjectMapping;
using OtenTool.PostmanCore.Services.Concretes;
using OtenTool.PostmanCore.Services.Interfaces;

namespace OtenTool.PostmanCoreCore
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            // Servis koleksiyonu
            var services = new ServiceCollection();

            // AutoMapper ekleniyor
            services.AddAutoMapper(typeof(MappingProfile));

            // Context
            services.AddDbContext<PostmanContext>();

            // Formları DI ile kaydet
            services.AddTransient<frmMain>();
            services.AddTransient<frmPostman>();

            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ITreeItemService, TreeItemService>();
            services.AddScoped<IGetManService, GetManService>();
            services.AddScoped<IRequestItemService, RequestItemService>();

            // Servis sağlayıcı oluştur
            ServiceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ApplicationConfiguration.Initialize();
            Start();
        }

        public static void Start()
        {
            var frmLogin = new frmLogin();
            var frmDialogRes = frmLogin.ShowDialog();

            if (frmDialogRes == DialogResult.OK)
            {
                var mainForm = ServiceProvider.GetRequiredService<frmMain>();
                Application.Run(mainForm);
                Start();
            }
        }
    }
}