using System;
using System.Windows.Forms;

namespace Portal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblBox_Click(object sender, EventArgs e)
        {

        }

        private void BrndBrowBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)


            {
                BrndLocTxtBox.Text = fdlg.FileName;
            }
        }

        private void CompBrowBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                CmpLocTxtBox.Text = fdlg.FileName;
            }
        }

        private void clseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            string brnSourcePath = BrndLocTxtBox.Text;
            string brndestinationPath = @"C:\Portal\Client\img\";
            string brndestinationFilename = "brand_logo.png";
            string brnSourceFile = System.IO.Path.GetFullPath(brnSourcePath);
            string brndestinationFile = System.IO.Path.Combine(brndestinationPath, brndestinationFilename);

            string cmpSourcePath = CmpLocTxtBox.Text;
            string cmpdestinationPath = @"C:\Portal\Client\img\";
            string cmpdestinationFilename = "company_logo.png";
            string cmpsourceFile = System.IO.Path.GetFullPath(cmpSourcePath);
            string cmpdestinationFile = System.IO.Path.Combine(cmpdestinationPath, cmpdestinationFilename);
           
            System.IO.File.Copy(brnSourceFile, brndestinationFile, true);
                                    
            System.IO.File.Copy(cmpsourceFile, cmpdestinationFile, true);

            MessageBox.Show("Copy complete", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
         }

        private void RevertBtn_Click(object sender, EventArgs e)
        {
            
            System.IO.File.Copy(@"C:\Portal\Client\img\Original\brand_logo.png", @"C:\Portal\Client\img\brand_logo.png", true);
            System.IO.File.Copy(@"C:\Portal\Client\img\Original\company_logo.png", @"C:\Portal\Client\img\company_logo.png", true);
                     
            MessageBox.Show("Reverted back", "Reverted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
