using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class AuthenticationBLL
    {
        ModelDataContext db;

        public AuthenticationBLL()
        {
            db = new ModelDataContext();
        }

        public bool isAuth(string _email, string _password)
        {
            int _check = db.Users.Where(user => user.Email == _email && user.Password == _password).Count();
            if (_check > 0)
                return true;
            return false;
        }
    }
}
