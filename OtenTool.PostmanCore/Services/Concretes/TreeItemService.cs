using Microsoft.EntityFrameworkCore;
using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Models;
using OtenTool.PostmanCore.Services.Interfaces;

namespace OtenTool.PostmanCore.Services.Concretes
{
    public class TreeItemService : ITreeItemService
    {
        private readonly PostmanContext _context;

        public TreeItemService(PostmanContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GetTreeItemsAsync - Proje Id sine göre treeyi getirir
        /// </summary>
        /// <param name="projectId">Proje Id si</param>
        /// <returns></returns>
        public async Task<List<tTreeItem>> GetTreeItemsAsync(int projectId)
        {
            return await _context.tTreeItems.Where(x => x.ProjectItemId == projectId).ToListAsync();
        }
    }
}
