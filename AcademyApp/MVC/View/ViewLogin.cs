using AcademyApp.MVC.HelpController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.MVC.View
{
    class ViewLogin
    {
        public string GetLogin(string loginCheck) {
            return DataBaseRegistration.GetSetLoginOdb(loginCheck);
        }
    }
}
