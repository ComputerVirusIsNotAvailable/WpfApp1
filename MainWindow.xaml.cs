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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
            
            
            
            
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\Users\Student\Desktop\WpfApp1 — копия\projectdb.mdf;Integrated Security=True");
            //string query = "Select * from Logins Where login = '" + log_tb.Text.Trim() + "' and password = '" + pass_tb.Text.Trim() + "'";
            string cmd = "select * from Logins Where login = '" + log_tb.Text + "' and password = '" + pass_tb.Text + "' and Должность = '" + user_type.Text + "'";
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            //string cmbItemValue = user_type.SelectedItem.ToString();

            if(dtbl.Rows.Count == 1)
            {
                
                    
                        if (user_type.SelectedIndex == 0)
                        {
                            this.Hide();
                            new Admin_menu().ShowDialog();
                            ShowDialog();
                            this.Close();

                            
                        }
                        else if (user_type.SelectedIndex == 1)
                        {
                            this.Hide();
                            new Operator_menu().ShowDialog();
                            ShowDialog();
                            this.Close();

                            

                        }
                        else if (user_type.SelectedIndex == 2)
                        {
                            this.Hide();
                            new Specialist_menu().ShowDialog();
                            ShowDialog();
                            this.Close();

                            
                        }
                    
                    
                
            } else if(dtbl.Rows.Count == 0)
            {
                MessageBox.Show("Неправильно выбран Вид пользователся или Логин и/или Пароль неверны");
            }
        }

        private void log_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
