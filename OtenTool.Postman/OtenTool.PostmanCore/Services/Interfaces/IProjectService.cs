using OtenTool.PostmanCore.Models;

namespace OtenTool.PostmanCore.Services.Interfaces
{
    public interface IProjectService
    {
        Task<List<tProjectUserMap>> GetProjectListAsync(int activeUserId);
    }
}
