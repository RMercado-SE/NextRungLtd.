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
    /// Interaction logic for HNCcomputing.xaml
    /// </summary>
    public partial class HNCcomputing : Window
    {
        // Variables for all students marks //

        int mark1 = 0;
        int mark2 = 0;
        int mark3 = 0;
        int mark4 = 0;
        int mark5 = 0;

        // Variable for the result of the sum and average of the 5 student marks //

        int average = 0;


        public HNCcomputing()
        {
            InitializeComponent();

        // Will display the students name and number by gthering the information stored in the data class // 

            displayInfo.Text = Class.fullName + "\n SNC" + " " + Class.studenNumber;

        }

        // Function designed to store all 5 marks and calculate the total average //

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            try
            {

        // gathering the user inputs marks and assigning them to their respective variable //

                mark1 = int.Parse(txtmark1.Text);
                mark2 = int.Parse(txtmark2.Text);
                mark3 = int.Parse(txtmark3.Text);
                mark4 = int.Parse(txtmark4.Text);
                mark5 = int.Parse(txtmark5.Text);

        // Claculation to optain the average of all 5 marks //

                average = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;

        // Assigning the average to its corresponding data class variable //

                Class.averageMark = average;

        // If statement designed to ensure correct input from user //

                if ((mark1 < 0) || (mark1 > 100))
                {
                    MessageBox.Show("The mark for Computer Systems Fundamentals must be bettwen 0 & 100");
                    this.txtmark1.Text = ("");
                }
                else if ((mark2 < 0) || (mark2 > 100))
                {
                    MessageBox.Show("The mark for Developing Software: Introduction  must be bettwen 0 & 100");
                    this.txtmark2.Text = ("");
                }
                else if ((mark3 < 0) || (mark3 > 100))
                {
                    MessageBox.Show("The mark for Professionalism and Ethics in Computing must be bettwen 0 & 100");
                    this.txtmark3.Text = ("");
                }
                else if ((mark4 < 0) || (mark4 > 100))
                {
                    MessageBox.Show("The mark for Troubleshooting Computing Problems must be bettwen 0 & 100");
                    this.txtmark4.Text = ("");
                }
                else if ((mark5 < 0) || (mark5 > 100))
                {
                    MessageBox.Show("The mark for Project Management: An Introduction must be bettwen 0 & 100");
                    this.txtmark5.Text = ("");
                }
                else
                {

        // If all fields are correct the application will navigate to the next window, Progression // 

                    Progression progression = new Progression();
                    progression.Show();
                    this.Close();
                }
            }
            catch
            {

        // Warning to user to ensure all fields are correctly input //

                MessageBox.Show("Your input must be numeric");
            }

        }
    }
}
