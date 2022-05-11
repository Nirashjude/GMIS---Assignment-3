using GMIS___Assignment_03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GMIS___Assignment_03.Controller
{
    public class StudentGroupController
    {
        public StudentGroupController()
        {

        }

        public List<StudentGroup> GetAllStudentGroups()
        {
            List<StudentGroup> studentGroups = new List<StudentGroup>();

            string connectionString = "Database=gmis;Data Source=alacritas.cis.utas.edu.au;User Id=gmis;Password=gmis";
            var connection = new MySqlConnection(connectionString);
            var command = new MySqlCommand("select * from studentgroup", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            StudentGroup studentGroup = new StudentGroup();
            while (reader.Read())
            {
                studentGroups.Add(new StudentGroup
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                });
                studentGroups.Add(studentGroup);
            }
            return studentGroups;

        }
    }
}
