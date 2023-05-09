using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Reflection.Metadata.BlobBuilder;
using HRForms;
using System.Windows.Forms;

namespace HRForms
{
    public class Methods
    {
        public static bool IsNumber(string x)
        {    
           int k ;
           return int.TryParse(x,out k);
        }

        public void Add(int EmployeCode, string FirstName, string LastName, string Department)
        {


            Employee EmployeObj = new Employee(EmployeCode, FirstName, LastName, Department);
            string connectionString = "Server=DESKTOP-MBR2PDO\\DEVELOPER;Database=HRForms;User Id=sa;Password=SaSa111;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (EmployeObj.EmployeCode != 0 && EmployeObj.FirstName != "" && EmployeObj.Department != "")
                {
                    SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Employes (Code, FirstName, LastName,Department) VALUES (@EmployeCode, @FirstName, @LastName,@Department)", connection);
                    sqlCommand.Parameters.AddWithValue("@EmployeCode", EmployeObj.EmployeCode);
                    sqlCommand.Parameters.AddWithValue("@FirstName", EmployeObj.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", EmployeObj.LastName);
                    sqlCommand.Parameters.AddWithValue("@Department", EmployeObj.Department);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    connection.Close();
                }
                connection.Close();
            }
        }
        public List<Employee> AllFromDBtoList()
        {
            List<Employee> emplist = new List<Employee>();
            string connectionString = "Server=DESKTOP-MBR2PDO\\DEVELOPER;Database=HRForms;User Id=sa;Password=SaSa111;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand($"select Code,FirstName,LastName,Department from Employes", connection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee((int)reader["Code"], (string)reader["FirstName"], (string)reader["LastName"], (string)reader["Department"]);
                        emplist.Add(employee);
                    }
                    connection.Close();
                }
            }
            return emplist;
        }
     
    }
}
