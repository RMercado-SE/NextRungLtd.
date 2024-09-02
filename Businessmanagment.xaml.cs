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

// This window has not yet being developed, only navigation from main window to this window and back available at the moment //

namespace SQA
{
    /// <summary>
    /// Interaction logic for Businessmanagment.xaml
    /// </summary>
    public partial class Businessmanagment : Window
    {
        public Businessmanagment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
