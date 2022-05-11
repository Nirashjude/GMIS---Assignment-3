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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SearchPageButton_Click(object sender, RoutedEventArgs e)
        {
            StudentSearchPage main_search_page = new StudentSearchPage();
            main_search_page.Show();
            this.Hide();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
