using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;


namespace SoftServeITAcademy.FinalDemo
{
    [Serializable]
    public class ReadFromFile
    {
        public List<College> ReadFile(string path)
        {
            List<College> colleges = new List<College>();
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string line;
                College college = new College();
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != ";")
                    {
                        //College tmpCollege = college;
                        string[] data = line.Split('|');
                        switch (data[0])
                        {
                            case "college":
                                college.NameOfCollege = data[1];
                                college.Adress = data[2];
                                break;
                            case "student":
                                Student student = new Student(data[1], data[2], data[3]);
                                college.AddStudent(student);
                                break;
                            case "employee":
                                Employee employee = new Employee(data[1], data[2], Convert.ToDouble(data[3]));
                                college.AddEmployee(employee);
                                break;
                        }
                    }
                    else
                    {
                        colleges.Add(college);
                        college = new College();
                    }
                }
                reader.Close();
            }
            return colleges;
        }
    }
}
