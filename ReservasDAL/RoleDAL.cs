using ReservasEN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasDAL
{
     public class RoleDAL
    {
        

        public static async Task<Role> GetById(Role pRole)
        {
            var role = new Role();
            
            using (var dbCOntext = new comunDB())
            {
                role =  await dbCOntext.Roles.FirstOrDefaultAsync(s => s.Id == pRole.Id);
            }
            return role;
        }
    }
}