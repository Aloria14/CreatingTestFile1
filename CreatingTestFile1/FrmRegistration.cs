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
        public string name, age, gender, program;
        public int age1;
        public long studentno, contactnumber;
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
                name = txtFirstName.Text + " " + txtLastName.Text + " " + txtMiddleName.Text;
                age = txtAge.Text;
                studentno = Convert.ToInt64(txtStudentNo.Text);
                age1 = int.Parse(txtAge.Text);
                dateofbirth = dateBirthdayPicker.Value;
                contactnumber = Convert.ToInt64(txtContactNo.Text);
        
        
                if (cbGender.SelectedItem?.ToString() == null || cbProgram.SelectedItem?.ToString() == null)
                {
                    MessageBox.Show("Please select a gender and program.");
                    return;
                }
                else if (name == "" || age == "" || studentno == 0 || contactnumber == 0)
                {
                    MessageBox.Show("Please fill all the name fields.");
                    return;
                }
                else
                {
                    FileStream stream = new FileStream(FrmFileName.SetFileName, FileMode.Create);
                    string message = "Student No.: " + studentno +
                            "\n" + "Full Name: " + name +
                            "\n" + "Program: " + cbProgram.SelectedItem?.ToString() +
                            "\n" + "Gender: " + cbGender.SelectedItem?.ToString() +
                            "\n" + "Age: " + age +
                            "\n" + "Birthday: " + dateofbirth +
                            "\n" + "Contact Number: " + contactnumber;
        
                    // Convert text into bytes
                    byte[] data = Encoding.UTF8.GetBytes(message);
        
                    // Write data to the file
                    stream.Write(data, 0, data.Length);
        
                    // Close the stream
                    stream.Close();
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
    }
}
