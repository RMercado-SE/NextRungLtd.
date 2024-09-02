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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Variables to store the names and student numbers //

        string firstName;
        string secondName;
        string studentNumber;


        public MainWindow()
        {
            InitializeComponent();
        }

        // Function designed to gather the students information, once all fields are input correctly //
        // the application will navigate to the next window, HNC Computing //


        private void btnComputing_Click(object sender, RoutedEventArgs e)
        {
            // Prevents any undesired user inputs and for the application to crash //
            try
            {
                // Gathering the names and student numbers from the text boxses to their corresponding variables // 

                firstName = txtfirstName.Text;
                secondName = txtsecondName.Text;
                studentNumber = txtstudentNumber.Text;

                // if statements that will ensure correct data is being inputed //

                if (firstName.Length < 2)
                {
                    MessageBox.Show("First name must be at least 3 Charcters");
                }
                else if (firstName.Contains(' '))
                {
                    MessageBox.Show("First name must not contain any spaces");
                }
                else if (secondName.Length < 2)
                {
                    MessageBox.Show("Second name must be at least 3 Characters");
                }
                else if (secondName.Contains(' '))
                {
                    MessageBox.Show("Second name must not contain any spaces");
                }
                else if (studentNumber.Length != 9)
                {
                    MessageBox.Show("Student number must be numeric and contain 9 Characters");
                }
                else if (studentNumber.Contains(' '))
                {
                    MessageBox.Show("Student number must not contain any spaces");
                }
                else
                {
                    // Merging the first name and second name and assigning them  to their respective class variable //

                    Class.fullName = firstName + " " + secondName;

                    // Assigning the student number to their respective class variable //

                    Class.studenNumber = studentNumber;

                    // Function that will close this current window and open the HNC Computing window //

                    HNCcomputing hNCcomputing = new HNCcomputing();
                    hNCcomputing.Show();
                    this.Close();
                }
            }
            catch
            {
                // Warning message to the user to ensure all fields are correctly filled //

                MessageBox.Show("Please make sure all boxex are filled correctly");
            }
        }

        // Please refer to the comments for the btnComputing_Click functionality as this one works similar //

        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                firstName = txtfirstName.Text;
                secondName = txtsecondName.Text;
                studentNumber = txtstudentNumber.Text;


                if (firstName.Length <= 3)
                {
                    MessageBox.Show("First name must be at least 3 Charcters");
                }
                else if (firstName.Contains(' '))
                {
                    MessageBox.Show("First name must not contain any spaces");
                }
                else if (secondName.Length <= 3)
                {
                    MessageBox.Show("Second name must be at least 3 Characters");
                }
                else if (secondName.Contains(' '))
                {
                    MessageBox.Show("Second name must not contain any spaces");
                }
                else if (studentNumber.Length < 9)
                {
                    MessageBox.Show("Student number must be numeric and contain 9 Characters");
                }
                else if (studentNumber.Contains(' '))
                {
                    MessageBox.Show("Student number must not contain any spaces");
                }
                else
                {
                    Class.fullName = firstName + " " + secondName;
                    Class.studenNumber = studentNumber;

                    HNCinteractivemedia hNCinteractivemedia = new HNCinteractivemedia();
                    hNCinteractivemedia.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please make sure all boxex are filled correctly");
            }
        }


        // Please refer to the comments for the btnComputing_Click functionality as this one works similar //

        private void btnBusiness_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                firstName = txtfirstName.Text;
                secondName = txtsecondName.Text;
                studentNumber = txtstudentNumber.Text;


                if (firstName.Length <= 3)
                {
                    MessageBox.Show("First name must be at least 3 Charcters");
                }
                else if (firstName.Contains(' '))
                {
                    MessageBox.Show("First name must not contain any spaces");
                }
                else if (secondName.Length <= 3)
                {
                    MessageBox.Show("Second name must be at least 3 Characters");
                }
                else if (secondName.Contains(' '))
                {
                    MessageBox.Show("Second name must not contain any spaces");
                }
                else if (studentNumber.Length < 9)
                {
                    MessageBox.Show("Student number must be numeric and contain 9 Characters");
                }
                else if (studentNumber.Contains(' '))
                {
                    MessageBox.Show("Student number must not contain any spaces");
                }
                else
                {
                    Class.fullName = firstName + " " + secondName;
                    Class.studenNumber = studentNumber;

                    Businessmanagment businessmanagment = new Businessmanagment();
                    businessmanagment.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Please make sure all boxex are filled correctly");
            }
        }
    }
}
