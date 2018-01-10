using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoftServeITAcademy.FinalDemo
{
    [Serializable]
    public class Employee : IPerson
    {
        private string slp;
        private string position;
        private double salary;

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                value = salary;
            }
        }

        public string SLP
        {
            get
            {
                return slp;
            }

            set
            {
                value = slp;
            }
        }

        public Employee()
        {

        }

        public Employee(string SLP, string position, double salary)
        {
            this.slp = SLP;
            this.position = position;
            this.salary = salary;
        }


        public void Show()
        {
            Console.WriteLine("\nSLP: {0} \nPosition: {1} \nSalary: {2}", SLP, position, salary);
        }

        public void WriteToFileAllSortedEmployees()
        {
            using (StreamWriter writer = new StreamWriter("D:\\File2.txt", true))
            {
                writer.WriteLine(SLP + position + Salary);
                writer.Close();
            }

        }
    }
}
