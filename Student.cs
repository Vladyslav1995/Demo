using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace SoftServeITAcademy.FinalDemo
{
    [Serializable]
    public class Student : IPerson
    {
        private string fio;
        private string group;
        private string fieldOfStudy;

        public string FIO
        {
            get
            {
                return fio;
            }
            set
            {
                value = fio;
            }
        }

        public string FieldOfStudy
        {
            get
            {
                return fieldOfStudy;
            }
            set
            {
                value = fieldOfStudy;
            }
        }

        public Student()
        {
            // Show();
        }

        public Student(string FIO, string group, string fieldOfStudy)
        {
            this.FIO = FIO;
            this.group = group;
            this.fieldOfStudy = fieldOfStudy;
        }

        public void Show()
        {
            Console.WriteLine("\nSLP: {0} \nGroup: {1} \nField of study: {2}", FIO, group, fieldOfStudy);
        }
    }
}
