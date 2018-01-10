using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace SoftServeITAcademy.FinalDemo
{
    public class Run
    {
        public static void Main(string[] args)
        {

            Logger.InitLogger();

            FileWriter fileWriter = new FileWriter();
            fileWriter.WriteToFileAllStudents();
            
            Console.ReadLine();
        }
    }
}
