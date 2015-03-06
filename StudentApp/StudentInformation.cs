using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class StudentInformation : Form
    {
       List<Student> studentList = new List<Student>(); 
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent =new Student();
            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            studentList.Add(aStudent);
           
            regNoTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            
            

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string a = "";
            foreach (Student student in studentList)
            {   

                a += student.regNo+ "\t " + student.GetfullName() +"\n";
            }
            MessageBox.Show("Reg No \t Full Name"+"\n"+"---------------" +"\n" +a);
        }
         
    }
}
