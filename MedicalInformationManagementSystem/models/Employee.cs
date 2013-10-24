class Employee
{
    public Employee(int employeeID, string hireDate, string userName, string password)
    {
      employeeID    = employeeID;
      hireDate      = hireDate;
      userName      = userName;
      password      = password;
    }
    
    public int employeeID     { get; private set; }
    public string hireDate    { get; private set; }
    public string userName    { get; private set; }
    public string password    { get; private set; }
}
