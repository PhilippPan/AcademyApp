using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.ApplicationData
{
    class StudentHelpClass
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Date { get; set; } = DateTime.Now.ToString();
    }
}
