using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Employee_Admin.xaml
    /// </summary>
    public partial class Employee_Admin : Window
    {
        DataSet ds;
        SqlDataAdapter dataAdapter;

        public Employee_Admin()
        {
            InitializeComponent();
            binddatagrid();
        }

        public void binddatagrid()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.cn"].ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from [Employees]";
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Employees");
            adapter.Fill(dt);

            g1.ItemsSource = dt.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

            new Admin_menu().ShowDialog();


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*string connectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.C__USERS_STUDENT_DESKTOP_WPFAPP1___КОПИЯ_PROJECTDB_MDFConnectionString"].ConnectionString;
            SqlCommand sql = new SqlCommand();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommandBuilder com = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = new SqlCommand("Employees", con);
                adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IdEmployee", SqlDbType.Int, 0, "IdEmployee"));
                adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Должность", SqlDbType.NVarChar, 50, "Должность"));
                adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ФИО", SqlDbType.NVarChar, 50, "ФИО"));

                SqlParameter parameter = adapter.UpdateCommand.Parameters.Add("@IdEmployee", SqlDbType.Int, 0, "IdEmployee");
                parameter.Direction = ParameterDirection.Output;
                adapter.Update();
                con.Close();

            }*/
            
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["WpfApp1.Properties.Settings.cn"].ConnectionString;
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from Employees", con);

            DataSet ds = new DataSet();
            a.Fill(ds, "Employees");
            
            g1.DataContext = ds;
            SqlCommandBuilder builder = new SqlCommandBuilder(a);
            a.UpdateCommand = builder.GetUpdateCommand();
            a.Update(ds, "Employees");*/

            /*SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\projectdb.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Employees SET IdEmployee = @IdEmployee, Должность = @Должность, ФИО = @ФИО " +
        "WHERE IdEmployee = @IdEmployee", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@IdEmployee", SqlDbType.Int, 1, "IdEmployee");
            cmd.Parameters.Add("@Должность", SqlDbType.NVarChar, 50, "Должность");
            cmd.Parameters.Add("@ФИО", SqlDbType.NVarChar, 50, "ФИО");
            SqlParameter parameter = cmd.Parameters.Add(
                "@IdEmployee", SqlDbType.Int, int.MaxValue, "IdEmployee");
            parameter.SourceVersion = DataRowVersion.Original;

            adapter.UpdateCommand = cmd;*/

            
        }
    }
}
