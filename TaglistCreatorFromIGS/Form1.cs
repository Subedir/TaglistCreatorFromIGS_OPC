using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaglistCreatorFromIGS
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.DialogResult resultIGS;
        System.Windows.Forms.DialogResult resultOPC;
        Boolean validIGSFile = false; // this is used to check if the IGS file uploaded is valid, default is false
        Boolean validOPCFile = false; // this is used to check if the OPC file uploaded is valid, default is false

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();

        }

        private void UploadIGSFile_Click(object sender, EventArgs e)
        {
            openIGSFile.Filter = "IGS file (*.csv)|*.csv|All files (*.*)|*.*";

            resultIGS = openIGSFile.ShowDialog();

            if (resultIGS == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string CSVFileOnly = Path.GetFileName(openIGSFile.FileName);
                    IGSFileText.Text = CSVFileOnly;
                    validIGSFile = CreateTagListFromIGS_OPC.checkIGSFile(openIGSFile.FileName);

                }
                catch (System.IO.FileNotFoundException fnfe)
                {
                    MessageBox.Show("File does not exist!\r\n\r\n" + fnfe.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



        private void UploadOPCFile_Click(object sender, EventArgs e)
        {
            openOPCFile.Filter = "OPC file (*.csv)|*.csv|All files (*.*)|*.*";

            resultOPC = openOPCFile.ShowDialog();

            if (resultOPC == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string CSVFileOnly = Path.GetFileName(openOPCFile.FileName);
                    OPCFileText.Text = CSVFileOnly;
                    validOPCFile = CreateTagListFromIGS_OPC.checkOPCFile(openOPCFile.FileName);

                }
                catch (System.IO.FileNotFoundException fnfe)
                {
                    MessageBox.Show("File does not exist!\r\n\r\n" + fnfe.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured\r\n\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void buttonGenerateTagList_Click(object sender, EventArgs e)
        {
            // this checks if the siteName and the Project Number boxes have been populated
            if (string.IsNullOrEmpty(txtAONumberBox.Text))
            {
                MessageBox.Show("Please enter a project Number");
                txtAONumberBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSiteBox.Text))
            {
                MessageBox.Show("Please enter a Site Name");
                txtSiteBox.Focus();
                return;
            }


            if (!(resultIGS == System.Windows.Forms.DialogResult.OK && validIGSFile == true))
            {
                MessageBox.Show("Please Upload a correct IGS config (.csv) file");
                return;

            }
            else if(!(resultOPC == System.Windows.Forms.DialogResult.OK && validOPCFile == true))
            {
                MessageBox.Show("Please Upload a correct OPC config (.csv) file");
                return;
            }
            else
            {
                string excelFileName = txtAONumberBox.Text + txtSiteBox.Text + "TagList"; // this is the excel file name without the extensions
                CreateTagListFromIGS_OPC obj = new CreateTagListFromIGS_OPC(openIGSFile.FileName, openOPCFile.FileName, excelFileName);
                obj.generateTagList(); // this generateTagList method is the only method that can be excuted from the createTagListFromIGS object

                return;

            }
        }

    }
}
