using ReservasDAL;
using ReservasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasBL
{
    public class RoleBL
    {
        public static async Task<Role> GetById(Role pRole)
        {
            return await RoleDAL.GetById(pRole);
        }
    }
}
