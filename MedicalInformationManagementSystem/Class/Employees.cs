using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem
{
    public class Employees
    {
        public DataTable EmployeeTable;
        
        public Employees()
        {
            getEmployees();
        }

        public void getEmployees()
        {
            Dictionary<String, String> param = new Dictionary<string,string>();
            DatabaseConnector dconn = new DatabaseConnector();
            EmployeeTable = dconn.getData("getEmployees", param);
        }

        public Dictionary<String, String> getEmployee(String employeeID)
        {
            Dictionary<String, String> param = new Dictionary<string, string>();
            param.Add("employeeID", employeeID);
            DatabaseConnector dconn = new DatabaseConnector();
            DataTable results = dconn.getData("getEmployeeByID", param);

            Dictionary<String, String> r = new Dictionary<string, string>();
            r.Add("userName", results.Rows[0]["userName"].ToString());
            r.Add("role", results.Rows[0]["role"].ToString());
            r.Add("firstName", results.Rows[0]["firstName"].ToString());
            r.Add("lastName", results.Rows[0]["lastName"].ToString());
            r.Add("gender", results.Rows[0]["gender"].ToString());
            return r;
        }

        public void addEmployee(String UserName, String Password, String HireDate, String Role, String FirstName, String LastName, String DateOfBirth, String Gender)
        {
            // error checking needed
            if (String.IsNullOrEmpty(UserName))
            {
                throw new System.ArgumentNullException("User Name");
            }
            else if (String.IsNullOrEmpty(Password))
            {
                throw new System.ArgumentNullException("Password");
            }
            if (String.IsNullOrEmpty(Role))
            {
                throw new System.ArgumentNullException("Role");
            }
            else if (String.IsNullOrEmpty(FirstName))
            {
                throw new System.ArgumentNullException("First Name");
            }
            else if (String.IsNullOrEmpty(FirstName))
            {
                throw new System.ArgumentNullException("Last Name");
            }
            else
            {
                Password = Encrypt.MD5(Password);

                Dictionary<String, String> param = new Dictionary<string, string>();
                param.Add("userName", UserName);
                param.Add("password", Password);
                param.Add("hireDate", HireDate);
                param.Add("role", Role);
                param.Add("firstName", FirstName);
                param.Add("lastName", LastName);
                param.Add("dateOfBirth", DateOfBirth);
                param.Add("gender", Gender);

                DatabaseConnector dconn = new DatabaseConnector();
                DataTable results = dconn.getData("addEmployee", param);
            }
        }

        public void editEmployee(String employeeID, String UserName, String Password, String Role, String FirstName, String LastName, String Gender)
        {
            // more error checking needed
            if (String.IsNullOrEmpty(employeeID))
            {
                throw new System.ArgumentNullException("employeeID");
            }
            else if (String.IsNullOrEmpty(UserName))
            {
                throw new System.ArgumentNullException("User Name");
            }
            else if (String.IsNullOrEmpty(Password))
            {
                throw new System.ArgumentNullException("Password");
            }
            if (String.IsNullOrEmpty(Role))
            {
                throw new System.ArgumentNullException("Role");
            }
            else if (String.IsNullOrEmpty(FirstName))
            {
                throw new System.ArgumentNullException("First Name");
            }
            else if (String.IsNullOrEmpty(FirstName))
            {
                throw new System.ArgumentNullException("Last Name");
            }
            else
            {
                Dictionary<String, String> param = new Dictionary<string, string>();
                param.Add("employeeID", employeeID);
                param.Add("userName", UserName);
                param.Add("role", Role);
                param.Add("firstName", FirstName);
                param.Add("lastName", LastName);
                param.Add("gender", Gender);

                DatabaseConnector dconn = new DatabaseConnector();
                DataTable results = dconn.getData("editEmployee", param);

                if (!String.IsNullOrEmpty(Password))
                {
                    Password = Encrypt.MD5(Password);

                    param = new Dictionary<string, string>();
                    param.Add("employeeID", employeeID);
                    param.Add("password", Password);

                    dconn = new DatabaseConnector();
                    results = dconn.getData("editEmployeePassword", param);
                }
            }
        }

        public void deleteEmployee(String employeeID)
        {
            if (String.IsNullOrEmpty(employeeID))
            {
                throw new System.ArgumentNullException("employeeID");
            }
            else
            {
                Dictionary<String, String> param = new Dictionary<string, string>();
                param.Add("employeeID", employeeID);
                DatabaseConnector dconn = new DatabaseConnector();
                DataTable results = dconn.getData("deleteEmployee", param);
            }
        }
    }
}
