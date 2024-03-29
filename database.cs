﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace GMIS___Assignment_03
{
    abstract class database
    {

        //These would not be hard coded in the source file normally, but read from the application's settings (and, ideally, with some amount of basic encryption applied)
        private const string db = "gmis";
        private const string user = "gmis";
        private const string pass = "gmis";
        private const string server = "alacritas.cis.utas.edu.au";

        private static MySqlConnection conn = null;

        //This method is a gift to you because .NET's approach to converting strings to enums is so horribly broken
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        /// <summary>
        /// Creates and returns (but does not open) the connection to the database.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                //Note: This approach is not thread-safe
                string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
                conn = new MySqlConnection(connectionString);

            }
            return conn;
        }


        //public static List<Employee> LoadAll()
        //{
        //    List<Employee> staff = new List<Employee>();

        //    MySqlConnection conn = GetConnection();
        //    MySqlDataReader rdr = null;

        //    try
        //    {
        //        conn.Open();

        //        MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name from researcher", conn);
        //        rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            //Note that in your assignment you will need to inspect the *type* of the
        //            //employee/researcher before deciding which kind of concrete class to create.
        //            staff.Add(new Employee { ID = rdr.GetInt32(0), Name = rdr.GetString(1) + " " + rdr.GetString(2) });
        //        }
        //    }
        //    catch (MySqlException e)
        //    {
        //        Console.WriteLine("Error connecting to database: " + e);
        //    }
        //    finally
        //    {
        //        if (rdr != null)
        //        {
        //            rdr.Close();
        //        }
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }

        //    return staff;
        //}

        //public static List<TrainingSession> LoadTrainingSessions(int id)
        //{
        //    List<TrainingSession> work = new List<TrainingSession>();

        //    MySqlConnection conn = GetConnection();
        //    MySqlDataReader rdr = null;

        //    try
        //    {
        //        conn.Open();

        //        MySqlCommand cmd = new MySqlCommand("select title, year, type, available " +
        //                                            "from publication as pub, researcher_publication as respub " +
        //                                            "where pub.doi=respub.doi and researcher_id=?id", conn);

        //        cmd.Parameters.AddWithValue("id", id);
        //        rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            work.Add(new TrainingSession
        //            {
        //                Title = rdr.GetString(0),
        //                Year = rdr.GetInt32(1),
        //                Mode = ParseEnum<Mode>(rdr.GetString(2)),
        //                Certified = rdr.GetDateTime(3)
        //            });
        //        }
        //    }
        //    catch (MySqlException e)
        //    {
        //        Console.WriteLine("Error connecting to database: " + e);
        //    }
        //    finally
        //    {
        //        if (rdr != null)
        //        {
        //            rdr.Close();
        //        }
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }

        //    return work;
        //}

        ////This is useful if the necessary data has not been loaded into memory yet.
        //public static int EmployeeTrainingCount(Employee e, int startYear, int endYear)
        //{
        //    MySqlConnection conn = GetConnection();
        //    int count = 0;

        //    try
        //    {
        //        conn.Open();

        //        MySqlCommand cmd = new MySqlCommand("select count(*) from publication as pub, researcher_publication as respub " +
        //                                            "where pub.doi = respub.doi and researcher_id = ?id and year >= ?start and year <= ?end", conn);
        //        cmd.Parameters.AddWithValue("id", e.ID);
        //        cmd.Parameters.AddWithValue("start", startYear);
        //        cmd.Parameters.AddWithValue("end", endYear);
        //        count = Int32.Parse(cmd.ExecuteScalar().ToString());
        //    }
        //    catch (MySqlException ex)
        //    {
        //        Console.WriteLine("Error connecting to database: " + ex);
        //    }
        //    finally
        //    {
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }

        //    return count;
        //}

        ////This method is now obsolete.
        //public static List<Employee> Generate()
        //{
        //    return new List<Employee>() {
        //        new Employee { Name = "Jane", ID = 1, Gender = Gender.F },
        //        new Employee { Name = "John", ID = 3, Gender = Gender.M },
        //        new Employee { Name = "Mary", ID = 7, Gender = Gender.F },
        //        new Employee { Name = "Lindsay", ID = 5, Gender = Gender.X },
        //        new Employee { Name = "Meilin", ID = 2, Gender = Gender.F }
        //    };
        //}
    }

}
