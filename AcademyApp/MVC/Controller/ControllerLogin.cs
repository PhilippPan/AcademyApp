using AcademyApp.MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.MVC.Controller
{
    class ControllerLogin
    {
        public string CheckLoginInOdb(string loginCheck) {
            ViewLogin viewLogin = new ViewLogin();
            return viewLogin.GetLogin(loginCheck);
        }
    }
}
