using Esfe.SysLoginEF.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysLoginEF.DAL
{
    public class RoleDAL
    {
        public static async Task<Role> GetById(Role pRole)
        {
            var role = new Role();
            using(var dbContext = new ComunDB())
            {
                role = await dbContext.Roles.FirstOrDefaultAsync(s => s.Id == pRole.Id);
            }
            return role;

        }
        public static async Task<int> Create(Role pRole)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(pRole);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update(Role pRole)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var role = await bdContext.Roles.FirstOrDefaultAsync(r => r.Id == pRole.Id);
                role.Name = pRole.Name;
                bdContext.Update(pRole);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }

        public static async Task<int> Delete(Role pRole)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                var role = await bdContext.Roles.FirstOrDefaultAsync(r => r.Id == pRole.Id);
                bdContext.Remove(role);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<Role>> GetAll()
        {
            var roles = new List<Role>();
            using (var bdContext = new ComunDB())
            {
               roles = await bdContext.Roles.ToListAsync();
            }
            return roles;
        }

    }
}
