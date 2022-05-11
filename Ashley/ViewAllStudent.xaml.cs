using MySql.Data.MySqlClient;
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

namespace GMIS___Assignment_03.Ashley
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ViewAllStudent : Window
    {
        public ViewAllStudent()
        {
            InitializeComponent();
            string connectionString = "Database=gmis;Data Source=alacritas.cis.utas.edu.au;User Id=gmis;Password=gmis";
            var connection = new MySqlConnection(connectionString);
            var command = new MySqlCommand("select * from student", connection);
            connection.Open();
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            dtstudent.Datacontext = dt;
        }

      
    }
    }
    
}
