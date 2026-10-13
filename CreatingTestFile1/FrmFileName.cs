using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreatingTestFile1
{
    public partial class FrmFileName : Form
    {
        FrmRegistration fr;

        internal static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
            fr = new FrmRegistration();
        }


        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt";
            try
            {
                if (SetFileName == "")
                {
                    MessageBox.Show("Error. Please Input a value");
                }
                else
                {
                    FileStream stream = new FileStream(SetFileName, FileMode.Create);
                    string message = "This is a test file.";

                    // Convert text into bytes
                    byte[] data = Encoding.UTF8.GetBytes(message);

                    // Write data to the file
                    stream.Write(data, 0, data.Length);

                    // Close the stream
                    stream.Close();

                    //MessageBox.Show("File created successfully!");
                    FrmRegistration fr = new FrmRegistration();
                    fr.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured" + ex);
            }
            finally
            {
            }
        }
    }
}
