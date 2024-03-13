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

namespace AcademyApp.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageDeleteStudent.xaml
    /// </summary>
    public partial class PageDeleteStudent : Page
    {
        private int SelectGroup;
        public PageDeleteStudent()
        {
            InitializeComponent();

            GridDeleteStudent.ItemsSource = AppConnect.modelOdb.Student.ToList();
            CmbGroup.SelectedValuePath = "Id";
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.ItemsSource = AppConnect.modelOdb.NameGroup.ToList();
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            GridDeleteStudent.ItemsSource = AppConnect.modelOdb.Student.Where(x => x.IdNameGroup == SelectGroup).ToList();
        }

        private void BtnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (GridDeleteStudent.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < GridDeleteStudent.SelectedItems.Count; i++) {
                        Student studentObj = GridDeleteStudent.SelectedItems[i] as Student;
                        AppConnect.modelOdb.Student.Remove(studentObj);
                    }
                    AppConnect.modelOdb.SaveChanges();
                    MessageBox.Show("Студент успешно удален!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    GridDeleteStudent.ItemsSource = AppConnect.modelOdb.Student.Where(x => x.IdNameGroup == SelectGroup).ToList();
                }
                else {
                    MessageBox.Show("В таблице нет данных!", "Уведомление", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(),
                    "Критическая работа приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
