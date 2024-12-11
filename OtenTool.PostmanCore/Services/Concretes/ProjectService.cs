using Microsoft.EntityFrameworkCore;
using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Models;
using OtenTool.PostmanCore.Services.Interfaces;

namespace OtenTool.PostmanCore.Services.Concretes
{
    public class ProjectService : IProjectService
    {
        private readonly PostmanContext _context;
        public ProjectService(PostmanContext context)
        {
            _context = context;
        }
        // GetProjectListAsync - Active kullanıcının projelerini getirir
        public async Task<List<tProjectUserMap>> GetProjectListAsync(int activeUserId)
        {

            List<tProjectUserMap>? res = await _context.tProjectUserMaps.Where(x => x.UserId == activeUserId).Include(x => x.tProject).ToListAsync();

            return res ?? new List<tProjectUserMap>();
        }
    }
}
