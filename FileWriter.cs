using System;
using System.Collections.Generic;
using System.IO;

namespace SoftServeITAcademy.FinalDemo
{
    [Serializable]
    class FileWriter
    {
        public void WriteToFileAllStudents()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("D:\\File1.txt", true))
                {
                    ReadFromFile reader = new ReadFromFile();
                    List<College> colleges = reader.ReadFile("D:\\File.txt");

                    foreach (College college in colleges)
                    {
                        college.Show();
                    }

                    foreach (College college in colleges)
                    {
                        List<string> fieldsOfStudy = college.GetUniqFieldOfStudy();
                        foreach (string field in fieldsOfStudy)
                        {
                            int studentNumber = college.GetStudentsNumberByFieldOfStudy(field);
                            writer.WriteLine(studentNumber + " students study in " + field + college.NameOfCollege);
                        }
                    }
                    writer.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                Logger.Log.Error(ex.Message);
            }
            catch (IOException ex)
            {
                Logger.Log.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex.Message);
            }
        }
    }
}
