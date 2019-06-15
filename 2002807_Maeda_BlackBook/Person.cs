using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_BlackBook
{
    public class Person
    {
        public string name { get; set; }
        public int phoneNum { get; set; }
        public int pagerNum { get; set; }
        public int cellNum { get; set; }
        public int voiceNum { get; set; }
        public string emailAdd { get; set; }

        public Person(string n, int ph, int pa, int cellN, int vm, string ea)
        {
            name = n;
            phoneNum = ph;
            pagerNum = pa;
            cellNum = cellN;
            voiceNum = vm;
            emailAdd = ea;
        }

        public void SavePersonData()
        {
            string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            string projectDir = Directory.GetParent(currentDir).Parent.FullName;
            string[] filePath = { projectDir, "Employee.Txt" };
            string FullPath = Path.Combine(filePath);
            string personInfo = name + "," + phoneNum + "," + pagerNum + "," + cellNum + "," + voiceNum + "," + emailAdd  + Environment.NewLine;


            //check if file exists
            if (File.Exists(FullPath) == false)
            {
                //if file does not exist, create it
                using (FileStream fs = File.Create(FullPath))
                {
                    Byte[] person = new UTF8Encoding(true).GetBytes(personInfo);
                    fs.Write(person, 0, person.Length);
                }
            }
            else
            {
                //append new employee information to file
                using (StreamWriter sw = File.AppendText(FullPath))
                {
                    sw.WriteLine(personInfo);
                }
            }
        }
    }



}
