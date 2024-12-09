using Microsoft.EntityFrameworkCore;
using OtenTool.PostmanCore.Constants;
using OtenTool.PostmanCore.Contexts;
using OtenTool.PostmanCore.Dtos;

namespace OtenTool.PostmanCore.Services.Concretes
{
    public class UserService
    {
        /// <summary>
        /// LoginAsync - Login işlemi yapar
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<bool> LoginAsync(UserLoginDto dto)
        {
            using (PostmanContext context = new PostmanContext())
                CacheConstants.LoginUser = await context.tUsers.Where(x => x.UserName == dto.UserName && x.Password == dto.Password).FirstOrDefaultAsync();

            return CacheConstants.LoginUser != null;
        }
    }
}
