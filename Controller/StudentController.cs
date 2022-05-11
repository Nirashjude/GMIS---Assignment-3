using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMIS___Assignment_03.Model;
using MySql.Data.MySqlClient;


namespace GMIS___Assignment_03.Controller
{
    public class StudentController
    {
        public StudentController()
        {

        }

        public List<Student> GetStudentById (string studentId)
        {
            List<Student> students = new List<Student>();

            string connectionString = "Database=gmis;Data Source=alacritas.cis.utas.edu.au;User Id=gmis;Password=gmis";
            var connection = new MySqlConnection(connectionString);
            var command = new MySqlCommand(String.Format("select * from student where student_id={0},", studentId), connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();            
            Student student = new Student();
            while (reader.Read())
            {
                students.Add(new Student
                {
                    studentId = reader.GetString(0),
                    GivenName = reader.GetString(1),
                    FamilyName = reader.GetString(2),
                    Group_id= reader.GetString(3),
                    Title= reader.GetString(4),
                    Campus= reader.GetString(5),
                    Phone= reader.GetString(6),
                    Email= reader.GetString(7),
                    Photo= reader.GetString(8),
                    Category= reader.GetString(9),
                    

                });
                students.Add(student);
            }
            return students;
        }
    }
}
