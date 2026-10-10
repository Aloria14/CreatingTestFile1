namespace CreatingTestFile1
{
    partial class FrmFileName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            txtFileName.Location = new Point(24, 32);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(328, 26);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold);
            btnOkay.Location = new Point(136, 72);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(100, 30);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 136);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}