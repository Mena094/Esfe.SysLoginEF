using Esfe.SysLoginEF.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysLoginEF.DAL
{
    public class UserDAL
    {
        public static async Task<User> Login(User pUser)
        {
            User user = new User();
            using (var dbContext = new ComunDB())
            {
                user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == pUser.UserName && 
                u.Password == pUser.Password);
            }
            return user;
        }

    }
}
