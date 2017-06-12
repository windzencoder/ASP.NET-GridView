using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// EmployeeDataAccessLayer 的摘要说明
/// </summary>

namespace GridView
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }

    public class EmployeeDataAccessLayer
    {
        public EmployeeDataAccessLayer()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();
            string CS = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(rdr["EmployeeId"]);
                    employee.Name = rdr["Name"].ToString();
                    employee.Gender = rdr["Gender"].ToString();
                    employee.City = rdr["City"].ToString();

                    listEmployees.Add(employee);
                }
            }

            return listEmployees;
        }

        //删除Employee
        public static void DeleteEmployee(int EmployeeId)
        {
            string CS = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("delete from tblEmployee where EmployeeId = @EmployeeId",con);
                SqlParameter param = new SqlParameter("@EmployeeId", EmployeeId);
                cmd.Parameters.Add(param);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
