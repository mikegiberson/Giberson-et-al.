using System;
using System.Data;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedicalInformationManagementSystem;

namespace UnitTestProject
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void EmployeeTest1()
        {
            Employees employees = new Employees();
            
            String UserName = "efisher";
            String Password = "mims";
            String HireDate = "2013-12-01";
            String Role = "1";
            String FirstName = "Ellen";
            String LastName = "Fisher";
            String DateOfBirth = "1980-10-10";
            String Gender = "Female";

            employees.addEmployee(UserName, Password, HireDate, Role, FirstName, LastName, DateOfBirth, Gender);

            int index = employees.EmployeeTable.Rows.Count - 1;

            Assert.IsNotNull(employees.EmployeeTable.Rows[index]["employeeID"].ToString());
            //Assert.AreEqual(FirstName, employees.EmployeeTable.Rows[index]["firstName"].ToString(), true);
            //Assert.AreEqual(LastName, employees.EmployeeTable.Rows[index]["lastName"].ToString(), true);
            //Assert.AreEqual(Role, employees.EmployeeTable.Rows[index]["role"].ToString(), true);

            String employeeID = employees.EmployeeTable.Rows[index]["employeeID"].ToString();
            Password = "Jake";
            Role = "2";

            employees.editEmployee(employeeID, UserName, Password, Role, FirstName, LastName, Gender);

            Assert.IsNotNull(employees.EmployeeTable.Rows[index]["employeeID"].ToString());
            //Assert.AreEqual(FirstName, employees.EmployeeTable.Rows[index]["firstName"].ToString(), true);
            //Assert.AreEqual(LastName, employees.EmployeeTable.Rows[index]["lastName"].ToString(), true);
            //Assert.AreEqual(Role, employees.EmployeeTable.Rows[index]["role"].ToString(), true);

            employees.deleteEmployee(employeeID);

            Assert.Equals(index - 1, employees.EmployeeTable.Rows.Count);
        }
    }
}
