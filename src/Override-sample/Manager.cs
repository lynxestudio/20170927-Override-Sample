using System;

namespace Samples.OOP
{
	public class Manager : Employee
	{
  		private string? m_Departament;
 
  		public string? Departament
  		{
    		get { return m_Departament; }
    		set { m_Departament = value; }
  		}

		public override string GetDetails()
		{
			return "Name: " + Name + Environment.NewLine +
			"Salary: " + Salary + Environment.NewLine +
			"Manager of: " + Departament;
		}
	}
}