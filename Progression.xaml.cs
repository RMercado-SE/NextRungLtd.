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

namespace SQA
{
    /// <summary>
    /// Interaction logic for Progression.xaml
    /// </summary>
    public partial class Progression : Window
    {

        // Main purpose of this function is to display information to the student //

        public Progression()
        {
            InitializeComponent();

        // Will display their full name, student number and average mark, all data gathered from the data class // 

            displayAverage.Text = Class.fullName + "\n" + Class.studenNumber + "\n" + "Average Mark - " + Class.averageMark;

        // If statement that willl display a message depending on the average mark // 

            if((Class.averageMark >= 80) && (Class.averageMark <=100))
            {
                displayoption.Text = " Option 1 - Progression onto the 2nd year of an appropiate degree " +
                                     " Programme with possible company sponsorship " +
                                     " (conditional on the successful completiton of all remaining HNC units";                       
            }
            else if((Class.averageMark >=70) && (Class.averageMark <=79))
            {
                displayoption.Text = " Option 2 - Progression onto the 2nd year of an appropiate degree" +
                                     " Programme (conditional on the successful completition of all " +
                                     " remaining HNC units)";
            }
            else if((Class.averageMark >=50) && (Class.averageMark <=69))
            {
                displayoption.Text = " Option 3 - Progression onto HND Networking or HND Software Development" +
                                     " will be offered (conditional on the successful completition of all " +
                                     " remaining HNC units)";
            }
            else
            {
                     _=(Class.averageMark >= 0) && (Class.averageMark <= 49);
                displayoption.Text = " Option 4 - No guaranteed progression to offer," +
                                     " student continues with remaining HNC units";
            }

        }

        // Function that will navigate back to the main window //

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();


        }

        // Function that will open a link on the user website to the UCAS Home web page, and navigate back to the main window // 

        private void btnUcas_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ucas.com");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
