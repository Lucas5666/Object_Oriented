using System;
namespace 泛化和关联
{
	public class Tester : Employee
	{
		//public float BaseSalary { get; set; }
		public float BugCount { get; set; }

		public override float CalculateSalary()
		{
			return BaseSalary + BugCount * 10;
		}
	}
}

