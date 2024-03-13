using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AcademyApp.SystemAppFunction
{
    /// <summary>
    /// Логика взаимодействия для WindowError.xaml
    /// </summary>
    public partial class WindowError : Window
    {
        private int TypeEvent;
        public WindowError(int eventId)
        {
            InitializeComponent();

            TypeEvent = eventId;

            EventSet();
        }

        public void EventSet() {
            
            switch (TypeEvent)
            {
                case 1:
                    TxtEvent.Text = "Информация успешно добавлена!";
                    break;
                default:
                TxtEvent.Text = "Ошибка работы приложения";
                break;
                
            }
            
        }

        private void BtnCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            return;
        }
    }
}
