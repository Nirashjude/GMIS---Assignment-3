using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMIS___Assignment_03.Controller
{
    public class StudentClassController
    {
        public StudentClassController()
        {

        }

        public List<StudentMasteroageView> GetStudentByFamilynamneAnd(string studentId)
        {
            List<Student> students = new List<Student>();

            string connectionString = "Database=gmis;Data Source=alacritas.cis.utas.edu.au;User Id=gmis;Password=gmis";
            var connection = new MySqlConnection(connectionString);
            var command = new MySqlCommand(String.Format("select * from student where student_id={0}", studentId), connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            Student student = new Student();
            while (reader.Read())
            {
                students.Add(new Student
                {
                    GivenName = reader.GetString(1),
                    FamilyName = reader.GetString(2),
                });
                students.Add(student);
            }
            return students;
        }
    }
}
