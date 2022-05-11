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
using MySql.Data.MySqlClient;

namespace GMIS___Assignment_03.Ashley
{
    /// <summary>
    /// Interaction logic for ViewAllGroup.xaml
    /// </summary>
    public partial class ViewAllGroup : Window
    {
        public ViewAllGroup()
        {
            InitializeComponent();
            string connectionString = "Database=gmis;Data Source=alacritas.cis.utas.edu.au;User Id=gmis;Password=gmis";
            var connection = new MySqlConnection(connectionString);
            var command = new MySqlCommand("select * from studentGroup", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            dtGrid.DataContext = dt;
        }

           
        }
}
