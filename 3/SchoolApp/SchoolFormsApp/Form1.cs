using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = txtName.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.State = txtState.Text;
            testSchool.Zip = txtZip.Text;
            testSchool.PhoneNumber = txtPhoneNumber.Text;
            try
            {
                testSchool.TwitterAddress = txtTwitter.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());


        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("The grade average for teacher is: " + gp);
        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.FirstName = "Misi";
            var message = student.SendMessage("Szevasz");
            var gp = student.ComputeGradeAverage();
            MessageBox.Show("The grade average for student is: " + gp);
            MessageBox.Show(message);

        }
    }
}
