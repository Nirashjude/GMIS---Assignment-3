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

using GMIS___Assignment_03.Controller;
using GMIS___Assignment_03.Jude;
using GMIS___Assignment_03.ViewModel;

namespace GMIS___Assignment_03
{
    /// <summary>
    /// Interaction logic for StudentSearchPage.xaml
    /// </summary>
    public partial class StudentSearchPage : Window
    {
        public StudentSearchPage()
        {
            InitializeComponent();
            database.GetConnection();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {   
            string input = StudentID.Text;

            if (input == "")
            {
                MessageBox.Show("Invalid Student ID");
                return;
            } 

              SearchOptions Search_Options = new SearchOptions();
               Search_Options.Show();
               this.Hide();


            //{
            //    SearchStudentClass StudentSearch_class = new SearchStudentClass(input);
            //    StudentController studentController = new StudentController();
            //    StudentViewModel studentVM = new StudentViewModel();
            //    studentVM.Students = studentController.GetStudentById(input);
            //    StudentSearch_class.DataContext = studentVM;
            //    StudentSearch_class.Show();                
            //    this.Hide();
            //}

        }

        private void StudentID_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("Enter Stuent ID:");
            //string StudentID = Console.ReadLine();
            Console.WriteLine("Your Sttudent ID is: " + StudentID);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
                MainPage main_page = new MainPage();
                main_page.Show();
                this.Hide();  
        }
    }
}

