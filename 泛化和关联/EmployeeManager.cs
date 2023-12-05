using System;
namespace 泛化和关联
{
	public class EmployeeManager
	{
		public List<Employee> AllEmployee; 

		//记录员工 计算薪资
		public float GetTotalSalary()
		{
			float total = 0;
			foreach (var item in AllEmployee)
			{
				total += item.CalculateSalary();
            }
			return total;

        }
	}
}

