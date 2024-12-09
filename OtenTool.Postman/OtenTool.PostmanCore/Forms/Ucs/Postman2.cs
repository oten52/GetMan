using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using OtenTool.PostmanCore.Constants;
using OtenTool.PostmanCore.Items;
using OtenTool.PostmanCore.Models;
using OtenTool.PostmanCore.Services.Interfaces;
using OtenTool.PostmanCoreCore;

namespace OtenTool.PostmanCore
{
    public partial class Postman2 : UserControl
    {
        private tRequestItem _tRequestItem;
        private PostmanRequestItem? _postmanRequestItem;
        private readonly IRequestItemService _requestItemService;

        public Postman2(ref tRequestItem tRequestItem)
        {
            _tRequestItem = tRequestItem;
            var scope = Program.ServiceProvider.CreateScope();

            _requestItemService = scope.ServiceProvider.GetRequiredService<IRequestItemService>();

            InitializeComponent();
        }



        private void BodyRadioButtonChanged(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();

            if (rbRaw.Checked)
            {
                pnlBody.Controls.Add(new Postman2_Body_Raw() { Dock = DockStyle.Fill });
            }
        }

        private void Postman2_Load(object sender, EventArgs e)
        {

            if (_tRequestItem != null)
            {
                if (_tRequestItem.Json != null)
                {
                    _postmanRequestItem = JsonConvert.DeserializeObject<PostmanRequestItem>(_tRequestItem.Json);
                }

                _postmanRequestItem ??= new PostmanRequestItem();

                if (_postmanRequestItem != null)
                {
                    txtUrl.Text = _postmanRequestItem.Url;
                }

            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            _postmanRequestItem.Url = txtUrl.Text.Trim();
            _tRequestItem.Json = JsonConvert.SerializeObject(_postmanRequestItem);
            _tRequestItem.Description = "Deneme";
            _tRequestItem.CreatedId = CacheConstants.LoginUser.Id;

            if (_tRequestItem.Id == 0)
            {
                _tRequestItem = await _requestItemService.AddAsync(_tRequestItem);
            }
            else
            {
                _tRequestItem = await _requestItemService.UpdateAsync(_tRequestItem);
            }
        }
    }
}
