using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duckling_aleatory_cats.MODEL;
using duckling_aleatory_cats.DAL.DBContext;

namespace duckling_aleatory_cats.BLL
{
    public class UserRepository
    {
        public TbUser Add(TbUser _tbuser)
        {
            using (var dbContext = new DbContext())
            {
                dbContext.Add(_tbuser);
                dbContext.SaveChanges();
                return _tbuser;
            }
        }

        public bool CheckLogin(TbUser _user)
        {
            using (var dbContext = new DbContext())
            {

                var user = dbContext.TbUsers.Single(p => p.Email == _user.Email && p.Password == _user.Password);
                return _user == null ? false : true;

            }
        }
    }
}
