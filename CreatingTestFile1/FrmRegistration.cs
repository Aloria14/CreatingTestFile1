using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreatingTestFile1
{
    public partial class FrmRegistration : Form
    {
        public string name, gender, program;
        public int age, studentno;
        public long contactnumber;
        public DateTime dateofbirth;
        public FrmRegistration()
        {
            InitializeComponent();
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbProgram.Items.Add("BSIT");
            cbProgram.Items.Add("BSCS");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                name = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;
                age = int.Parse(txtAge.Text);
                studentno = int.Parse(txtStudentNo.Text);
                dateofbirth = dateBirthdayPicker.Value;
                contactnumber = long.Parse(txtContactNo.Text);
                program = cbProgram.SelectedItem?.ToString();
                gender = cbGender.SelectedItem?.ToString();
        
        
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtMiddleName.Text))
                {
                    MessageBox.Show("Please fill in all the name fields.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Please enter your age.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
                {
                    MessageBox.Show("Please enter your student number.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtContactNo.Text))
                {
                    MessageBox.Show("Please enter your contact number.");
                    return;
                }
                else if (cbProgram.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a program.");
                    return;
                }
                else if (cbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }
                else
                {
                    FileStream stream = new FileStream(FrmFileName.SetFileName, FileMode.Create);
                    string message = "Student No.: " + studentno +
                            "\n" + "Full Name: " + name +
                            "\n" + "Program: " + program +
                            "\n" + "Gender: " + gender +
                            "\n" + "Age: " + age +
                            "\n" + "Birthday: " + dateofbirth +
                            "\n" + "Contact Number: " + contactnumber;

                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                    MessageBox.Show("Registration Successful!");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Input All Fields" + ex);
            }
            finally
            {
            
            }
        }
        public void ClearFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cbProgram.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
            dateBirthdayPicker.Value = DateTime.Now;
            txtStudentNo.Focus();
        }
    }
}
