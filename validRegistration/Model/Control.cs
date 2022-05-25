using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using validRegistration.DAL;

namespace validRegistration.Model
{
    public class Control
    {
        public bool save;
        public String message = " ";
        public bool acess(String username, String password)
        {
            LoginDalCommands loginDal = new LoginDalCommands();
            save = loginDal.checkLogin(username, password);
            if (!loginDal.message.Equals(""))
            {
                this.message = loginDal.message;
            }
            return save;
        }
        public String register(String email, String password, String confPassword)
        {
            return message;
        }
    }
}
