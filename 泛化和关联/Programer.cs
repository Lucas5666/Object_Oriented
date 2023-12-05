using System;
namespace 泛化和关联
{
	public class Programer : Employee
	{
		//public float BaseSalary { get; set; }
		public float Bonus { get; set; }

		public override float CalculateSalary()
		{
			return BaseSalary + Bonus;
		}
	}
}

