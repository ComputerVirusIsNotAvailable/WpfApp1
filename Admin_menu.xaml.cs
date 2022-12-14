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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Admin_menu.xaml
    /// </summary>
    public partial class Admin_menu : Window
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //this.Hide();
            new LoginsPasswords().ShowDialog();
            //ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            //this.Hide();
            new ResCont_Admin().ShowDialog();
            //ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            //this.Hide();
            new Employee_Admin().ShowDialog();
            //ShowDialog();



        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            //this.Hide();
            /*new MainWindow().ShowDialog();
            ShowDialog();*/
        }
    }
}
