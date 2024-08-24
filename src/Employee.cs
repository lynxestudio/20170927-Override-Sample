using System;

namespace Samples.OOP {
	public class Employee {
  		private string m_Name = "";
  		private double m_Salary;
  		private DateTime m_BirthDate;

  		public string Name {
    		get { return m_Name; }
    		set { m_Name = value; }
  		}

  		public double Salary {
    		get { return m_Salary; }
    		set { m_Salary = value; }
  		}
  
  		public DateTime BirthDate {
    		get { return m_BirthDate; }
    		set { m_BirthDate = value; }
  		}
  
  		public virtual string GetDetails() {
			return "Name: " + Name + "\n"
			+ "Salary: " + Salary + "\n"
			+ "BirthDate: " + BirthDate;
  		}
	}
}