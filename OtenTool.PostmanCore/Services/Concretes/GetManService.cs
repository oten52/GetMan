using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Services.Interfaces;

namespace OtenTool.PostmanCore.Services.Concretes
{
    public class GetManService : IGetManService
    {
        private readonly PostmanContext _context;
        public GetManService(PostmanContext context)
        {
            _context = context;
        }

    }
}
