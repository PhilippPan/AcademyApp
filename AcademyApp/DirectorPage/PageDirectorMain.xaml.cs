using AcademyApp.ApplicationData;
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
using System.Windows.Threading;

namespace AcademyApp.DirectorPage
{
    /// <summary>
    /// Логика взаимодействия для PageDirectorMain.xaml
    /// </summary>
    public partial class PageDirectorMain : Page
    {
        public PageDirectorMain()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += UpdateDataEvent;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        public void UpdateDataEvent(object sender, object e) { 
            GridEvent.ItemsSource = AppConnect.modelOdb.History.ToList();
        }
    }
}
