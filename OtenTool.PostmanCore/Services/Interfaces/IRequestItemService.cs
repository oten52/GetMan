using OtenTool.PostmanCore.Models;

namespace OtenTool.PostmanCore.Services.Interfaces
{
    public interface IRequestItemService
    {
        Task<tRequestItem?> GetRequestItemByIdAsync(int id);
        Task<tRequestItem> AddAsync(tRequestItem obj);
        Task<tRequestItem> UpdateAsync(tRequestItem obj);
    }
}
