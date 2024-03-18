using Microsoft.EntityFrameworkCore;
using ReservasEN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasDAL
{
    public class UserDAL
    {
        public static async Task<User> Login(User pUser)
        {
            User user = new User();
            using (var dbContext = new comunDB())
            {
                user = await dbContext.Users.FirstOrDefaultAsync(u => u.UserName == pUser.UserName && u.Password == pUser.Password);
            }
            return user;
        }
    }
}
