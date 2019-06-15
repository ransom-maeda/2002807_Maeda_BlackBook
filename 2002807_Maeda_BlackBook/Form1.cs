using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_BlackBook
{
    public partial class Form1 : Form
    {
        PersonList personList = new PersonList();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameInput.Text;
                int phoneNumber = int.Parse(phoneInput.Text);
                int pagerNum = int.Parse(pagerInput.Text);
                int cell = int.Parse(cellInput.Text);
                int voicemail = int.Parse(voicemailInput.Text);
                string email = emailInput.Text;

                Person person = new Person(name, phoneNumber, pagerNum, cell, voicemail, email);
                person.SavePersonData();
            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
        }

        private void lookUp_Click(object sender, EventArgs e)
        {
            string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            string projectDir = Directory.GetParent(currentDir).Parent.FullName;
            string[] filePath = { projectDir, "Person.Txt" };
            string FullPath = Path.Combine(filePath);

            //check if file exists
            if (File.Exists(FullPath))
            {
                using (var reader = new StreamReader(FullPath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] personInfo = line.Split(',');

                        if (personInfo.Length == 4)
                        {
                            Person person = new Person(personInfo[0].ToString(), int.Parse(personInfo[1]), int.Parse(personInfo[2]), int.Parse(personInfo[3]), int.Parse(personInfo[4]), personInfo[5]);
                            personList.addPerson(person);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Contact Info Missing", "Error");
            }
        }
    }
}
