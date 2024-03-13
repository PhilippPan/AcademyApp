using AcademyApp.ApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.MVC.HelpController
{
    class DataBaseRegistration
    {
        public static string GetSetLoginOdb(string getSetLogin) {
            User user = AppConnect.modelOdb.User.FirstOrDefault(x => x.Login == ClientInfo.LoginClient);
            while (true) {
                if (user != null && user.Login == getSetLogin) {
                    return "Пользователь есть!";
                }
                else {
                    return "Такого пользователя нет!";
                }
            }
        }
    }
}
