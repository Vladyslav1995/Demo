using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SoftServeITAcademy.FinalDemo
{
    [Serializable]
    public class College
    {
        private string nameOfCollege;
        private string adress;

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                value = adress;
            }
        }

        public string NameOfCollege
        {
            get
            {
                return nameOfCollege;
            }
            set
            {
                value = nameOfCollege;
            }
        }

        List<Student> students = new List<Student>();
        List<Employee> employees = new List<Employee>();

        public College()
        {

        }

        public College(string name, string address)
        {
            NameOfCollege = name;
            Adress = address;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void Show()
        {
            Console.WriteLine(this.NameOfCollege);
            Console.WriteLine(this.Adress);

            Console.WriteLine("Collage has " + this.students.Count + " students");
            foreach (Student student in this.students)
            {
                student.Show();
            }

            Console.WriteLine("Collage has " + this.employees.Count + " employees");

            foreach (Employee emplloyee in this.employees)
            {
                emplloyee.Show();
            }
        }

        public List<string> GetUniqFieldOfStudy()
        {
            List<string> fieldsOfStudy = new List<string>();
            for (int i = 0; i < this.students.Count(); i++)
            {
                if (!fieldsOfStudy.Contains(students[i].FieldOfStudy))
                {
                    fieldsOfStudy.Add(students[i].FieldOfStudy);
                }
            }
            return fieldsOfStudy;
        }

        public int GetStudentsNumberByFieldOfStudy(string fieldOfStudy)
        {
            int count = 0;
            foreach (Student student in this.students)
            {
                if (student.FieldOfStudy == fieldOfStudy)
                    count++;
            }
            return count;
        }
    }
}
