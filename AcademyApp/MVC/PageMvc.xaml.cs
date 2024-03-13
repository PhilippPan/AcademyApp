using AcademyApp.MVC.Controller;
using AcademyApp.MVC.HelpController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademyApp.MVC
{
    /// <summary>
    /// Логика взаимодействия для PageMvc.xaml
    /// </summary>
    public partial class PageMvc : Page
    {
        public PageMvc()
        {
            InitializeComponent();
        }

        private void BtnQuery_Click(object sender, RoutedEventArgs e)
        {
            ControllerLogin controllerLogin = new ControllerLogin();
            ClientInfo.LoginClient = TxbLogin.Text;

            MessageBox.Show(controllerLogin.CheckLoginInOdb(TxbLogin.Text));
        }
    }
}
