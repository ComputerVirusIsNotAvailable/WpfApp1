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
    /// Логика взаимодействия для Employee_Admin_Add.xaml
    /// </summary>
    public partial class Employee_Admin_Add : Window
    {
        public Employee_Admin_Add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WpfApp1 — копия\projectdb.mdf;Integrated Security=True");
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.cn"].ConnectionString;
            con.Open();
            
            string sql = "Insert into Employees(Должность,ФИО)values(N'" +  jb_txt.Text + "',N'" + fn_txt.Text + "')";
            //cmd.CommandText = "Insert into [Employees](Должность)values(@jb) and [Employees](ФИО)values(@nm)";
            SqlCommand cmd = new SqlCommand(sql, con);
            int a = cmd.ExecuteNonQuery();

            
            /*cmd.CommandText = "Insert into [Employees](ФИО)values(@nm)";
            cmd.Parameters.AddWithValue("@nm", fn_txt.Text);
            cmd.Connection = con;
            int b = cmd.ExecuteNonQuery();*/

            if(a==1)
            {
                MessageBox.Show("Данные успешно добавлены");
                this.Close();
                

            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
