using System;
using System.Collections.Generic;
using System.Data;
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
using GMIS___Assignment_03.Controller;
using GMIS___Assignment_03.Model;
using MySql.Data.MySqlClient;

namespace GMIS___Assignment_03.Jude
{
    /// <summary>
    /// Interaction logic for SearchStudentClass.xaml
    /// </summary>
    public partial class SearchStudentClass : Window
    {
        public SearchStudentClass(string studentId)
        {
            InitializeComponent();
            string connectionString = "Database=gmis;Data Source=alacritas.cis.utas.edu.au;User Id=gmis;Password=gmis";
            var connection = new MySqlConnection(connectionString);
            var command = new MySqlCommand("select * from student", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            dtGrid.DataContext = dt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainPage main_page = new MainPage();
            main_page.Show();
            this.Hide();
        }
    }
}
