using System;
namespace 泛化和关联
{
	public class Employee
	{
		public float BaseSalary { get; set; }
		public virtual float CalculateSalary()
		{
			return 3000;
		}
	}
}

