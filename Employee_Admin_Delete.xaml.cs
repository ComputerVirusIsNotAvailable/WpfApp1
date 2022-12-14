using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Employee_Admin_Delete.xaml
    /// </summary>
    public partial class Employee_Admin_Delete : Window
    {
        public Employee_Admin_Delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WpfApp1 — копия\projectdb.mdf;Integrated Security=True");
            
            con.Open();

            string sql = "Delete from Employees Where IdEmployee='"+this.id_txt.Text+"'";
            
            SqlCommand cmd = new SqlCommand(sql, con);
            int a = cmd.ExecuteNonQuery();


            

            if (a == 1)
            {
                MessageBox.Show("Данные успешно удалены");
                this.Close();


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
