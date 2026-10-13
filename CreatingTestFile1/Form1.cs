namespace CreatingTestFile1
{
    public partial class FrmLab1 : Form
    {
        FrmFileName FrmFileName = new FrmFileName();
        FrmRegistration fr = new FrmRegistration();
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == null || txtInput.Text == "")
            {
                MessageBox.Show("Error. Please Input a value");
            }
            else
            {
                string getInput = txtInput.Text + ".txt";
                FrmFileName.ShowDialog();

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No.: " + fr.studentno +
                    "\n" + "Full Name: " + fr.name +
                    "\n" + "Program: " + fr.program +
                    "\n" + "Gender: " + fr.gender +
                    "\n" + "Age: " + fr.age +
                    "\n" + "Birthday: " + fr.dateofbirth +
                    "\n" + "Contact Number: " + fr.contactnumber);
            }
                this.Close();
            }
        }
    }
}
