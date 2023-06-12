using duckling_days.MODEL;
using duckling_days.DAL.DBContext;
using System;

namespace duckling_days.BLL
{
    public class UserRepository
    {
        public void Add(TbUser _tbuser)
        {
            using ( var dbContext = new DbSet())
            {
                dbContext.Add(_tbuser);
                dbContext.SaveChanges();
            }
        }

        public bool CheckLogin(TbUser _user)
        {
            using ( var dbContext = new DbSet()) {

                var user = dbContext.TbUsers.Single(p => p.User == _user.User && p.Password == _user.Password);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }                
            }
        }
    }
}