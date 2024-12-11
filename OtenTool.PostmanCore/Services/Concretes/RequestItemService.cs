using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Models;
using OtenTool.PostmanCore.Services.Interfaces;

namespace OtenTool.PostmanCore.Services.Concretes
{
    public class RequestItemService : IRequestItemService
    {
        private readonly PostmanContext _context;
        public RequestItemService(PostmanContext context)
        {
            _context = context;
        }
        /// <summary>
        /// GetRequestItemAsync - Id ile getirme işlemi yapar 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<tRequestItem?> GetRequestItemByIdAsync(int id)
        {
            return await _context.tRequestItems.FindAsync(id);
        }

        /// <summary>
        /// AddAsync - 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<tRequestItem> AddAsync(tRequestItem obj)
        {
            await _context.tRequestItems.AddAsync(obj);

            await _context.SaveChangesAsync();

            return obj;
        }

        /// <summary>
        /// UpdateAsync - 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<tRequestItem> UpdateAsync(tRequestItem obj)
        {
            _context.tRequestItems.Update(obj);

            await _context.SaveChangesAsync();

            return obj;
        }
    }
}
