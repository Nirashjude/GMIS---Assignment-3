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
using System.Windows.Shapes;

namespace GMIS___Assignment_03
{
    /// <summary>
    /// Interaction logic for SearchOptions.xaml
    /// </summary>
    public partial class SearchOptions : Window
    {
        public SearchOptions()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            
               SearchStudentClass StudentSearch_class = new SearchStudentClass(input);
               StudentController studentController = new StudentController();
               StudentViewModel studentVM = new StudentViewModel();
               studentVM.Students = studentController.GetStudentById(input);
               StudentSearch_class.DataContext = studentVM;
               StudentSearch_class.Show();                
              this.Hide();
            
        }
    }
}
