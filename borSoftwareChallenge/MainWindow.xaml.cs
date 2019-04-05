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

namespace borSoftwareChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Recess> recesses = new List<Recess>();

        public static MainWindow main; // Allows MainWindow elements to be edited from other files
        public MainWindow()
        {
            InitializeComponent();
            main = this; // Assigns value for main to created instance of MainWindow class
        }

        private void btnAddRecess_Click(object sender, RoutedEventArgs e)
        {
            if (tbRecessName.Text == "" || tbRecessWidth.Text == "" || tbRecessHeight.Text == "" || tbRecessDepth.Text == "")
            {
                MessageBox.Show("One or more required inputs is missing");
            }
            else
            {
                try
                {
                    bool isDoor = false;
                    if (cbRecessIsDoor.IsChecked == true)
                    {
                        isDoor = true;
                    }
                    else if (cbRecessIsDoor.IsChecked == false)
                    {
                        isDoor = false;
                    }
                    Recess r = new Recess(tbRecessName.Text, tbRecessWidth.Text, tbRecessHeight.Text, tbRecessDepth.Text, isDoor); // Create new recess object
                    recesses.Add(r); // Add inputted data to recess list as recess object
                    lbRecesses.Items.Add(r); // Add inputted data to listbox as recess object
                    tbRecessName.Text = "";
                    tbRecessHeight.Text = "";
                    tbRecessWidth.Text = "";
                    tbRecessDepth.Text = "";
                    cbRecessIsDoor.IsChecked = false;
                }
                catch
                {
                    MessageBox.Show("One or more inputs was in an incorrect format");
                }
                
            }
        }

        private void lbRecesses_Context_Remove(object sender, RoutedEventArgs e)
        {
            if (lbRecesses.SelectedItem == null) { }
            else
            {
                Recess selectedRecess = (Recess)lbRecesses.SelectedItem; // Get selected Recess object
                recesses.Remove(selectedRecess); // Remove recess from recess list
                lbRecesses.Items.Remove(selectedRecess); // Remove recess from listbox
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {   
            if (tbRoomHeight.Text == "" || tbRoomLength.Text == "" || tbRoomWidth.Text == "")
            {
                MessageBox.Show("One or more required inputs is missing");
            }
            else
            {
                try
                {
                    Calculations.FillOutputs();
                }
                catch
                {
                    MessageBox.Show("One or more inputs was in an incorrect format");
                }
            }

            
        }
    }
}
