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

namespace GMIS___Assignment_03.Nhi
{
    /// <summary>
    /// Interaction logic for SearchStudentGroups.xaml
    /// </summary>
    public partial class SearchStudentGroups : Window
    {
        public SearchStudentGroups()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage main_page = new MainPage();
            main_page.Show();
            this.Hide();
        }
    }   
}
