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
using WebServiceClient.ValidationServiceReference;

namespace WebServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open File";
            ofd.Filter = "All Files|*.*";
            ofd.FileName = string.Empty;

            try
            {
                ofd.InitialDirectory = "C:\\";
            }
            catch (Exception ex)
            {

                throw;
            }

            ofd.ShowDialog();
            if (ofd.FileName == string.Empty)
            {
                return;
            }
            else
            {
                textFileName.Text = ofd.FileName;
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (textFileName.Text != string.Empty)
            {
                UploadFile(textFileName.Text);
            }
            else
            {
                MessageBox.Show("You must select a file", "No file selected");
            }
        }

        private void UploadFile(string fileName)
        {
            try
            {
                string stringfile = System.IO.Path.GetFileName(fileName);
                DocumentValidationWebServiceSoapClient srv = new DocumentValidationWebServiceSoapClient();
                FileInfo fileInfo = new FileInfo(fileName);
                long numberBytes = fileInfo.Length;
                double defaultLength = Convert.ToDouble(fileInfo.Length / 1000000);

                if (defaultLength < 4)
                {
                    FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] data = binaryReader.ReadBytes((int)numberBytes);
                    binaryReader.Close();
                    string stringTmp = srv.UploadDocument(data, stringfile);
                    fileStream.Close();
                    fileStream.Dispose();
                    DeclarationDocument declarationDocument = srv.ValidateDocument(stringTmp);
                    rtb_result.Text = $"Document structure {declarationDocument.DocumentStructure} {Environment.NewLine}";
                    rtb_result.AppendText($"Declaration Command {declarationDocument.DeclarationCommand} {Environment.NewLine}");
                    rtb_result.AppendText($"SiteId node {declarationDocument.SiteId}");
                }
                else
                {
                    MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }
        }
    }
}
