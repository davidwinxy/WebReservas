using ReservasDAL;
using ReservasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasBL
{
    public class UserBL
    {
        public static async Task<User> Login(User pUser)
        {
            return await UserDAL.Login(pUser);
        }
    }
}
