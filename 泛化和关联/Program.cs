namespace 泛化和关联;
class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager()
        {
            AllEmployee = new List<Employee>()
            {
                new Employee(){BaseSalary = 3000},
                new Programer(){BaseSalary = 3000,Bonus = 9999999},
                new Tester(){BaseSalary = 3000,BugCount = 30}
            }
        };

        float totalSalary = manager.GetTotalSalary();
    }
}

