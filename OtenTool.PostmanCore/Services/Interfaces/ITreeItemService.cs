using OtenTool.PostmanCore.Models;

namespace OtenTool.PostmanCore.Services.Interfaces
{
    public interface ITreeItemService
    {
        Task<List<tTreeItem>> GetTreeItemsAsync(int projectId);
    }
}
