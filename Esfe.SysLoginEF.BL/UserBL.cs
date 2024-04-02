using Esfe.SysLoginEF.DAL;
using Esfe.SysLoginEF.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysLoginEF.BL
{
    public class UserBL
    {
        public static async Task<User> Login(User pUser)
        {
            return await UserDAL.Login(pUser);
        }
    }
}
