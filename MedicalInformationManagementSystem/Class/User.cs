using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MedicalInformationManagementSystem
{
    public class User
    {
        public static int? ID;
        public int? Role;
        public String FirstName;
        public String LastName;
        
        public User()
        {
            ID = null;
            Role = null;
            FirstName = "";
            LastName = "";
        }

        public void Login(String UserName, String Password)
        {
            if (String.IsNullOrEmpty(UserName))
            {
                throw new System.ArgumentNullException("UserName");
            }
            else if (String.IsNullOrEmpty(Password))
            {
                throw new System.ArgumentNullException("Password");
            }
            else {
                Password = Encrypt.MD5(Password);

                Dictionary<String, String> param = new Dictionary<string,string>();
                param.Add("userName", UserName);
                DatabaseConnector dconn = new DatabaseConnector();
                DataTable result = dconn.getData("getEmployeeByUser", param);

                if (result.Rows.Count == 1)
                {
                    String p = result.Rows[0]["password"].ToString();
                    if (Object.Equals(p, Password))
                    {
                        ID = (int)result.Rows[0]["employeeID"];
                        Role = (int)result.Rows[0]["role"];
                        FirstName = result.Rows[0]["firstName"].ToString();
                        LastName = result.Rows[0]["lastName"].ToString();
                    }
                    else
                    {
                        throw new System.ArgumentException("Passwords do not match.");
                    }
                }
                else
                {
                    throw new System.ArgumentException("UserName does not exist in system.");
                }
            }
        }

        public void Logout()
        {
            ID = null;
            Role = null;
            FirstName = "";
            LastName = "";
        }
    }
}
