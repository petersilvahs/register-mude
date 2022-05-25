using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validRegistration.DAL;

namespace validRegistration.Model
{
    public class Controls
    {
        public bool have;
        public String message = "";
        public bool access(String username, String password)
        {
            LoginDalCommands loginDal = new LoginDalCommands();
            have = loginDal.checkLogin(username, password);
            if (!loginDal.message.Equals(""))
            {
                this.message = loginDal.message;
            }
            return have;
        }
        public String register(String email, String password, String confPassword)
        {
            return message;
        }
    }
}
