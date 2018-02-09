///Andrew Markham
///February 8, 2018
///u1_02AndrewOutput
///A program that asks for the users name and age and gives them a greeting.
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

namespace u1_01AndrewOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowGreeting_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "Hello, " + entryFirstName.Text + " " + entryLastName.Text + "." + "\nI see you are " + sliderAge.Value + " years old!";
        }
    }
}
