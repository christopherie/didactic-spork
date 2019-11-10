using DeclarationDocumentValidationWebService.Classes;
using DeclarationDocumentValidationWebService.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace DeclarationDocumentValidationWebService
{
    /// <summary>
    /// Summary description for DocumentValidationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DocumentValidationWebService : System.Web.Services.WebService, IDocumentValidation
    {

        [WebMethod]
        public DeclarationDocument ValidateDocument(string doc)
        {
            const string nodePattern = "InputDocument/DeclarationList/Declaration";
            DeclarationDocument declarationDocument = new DeclarationDocument();
            XmlDocument xmlDocument = new XmlDocument();

            try
            {
                xmlDocument.Load(doc);

                foreach (XmlNode item in xmlDocument.SelectNodes(nodePattern))
                {
                    string commandAttribute = item.Attributes["Command"].Value;

                    if (commandAttribute == "DEFAULT")
                    {
                        declarationDocument.DeclarationCommand = ValidationStatus.InvalidDeclarationCommand.ToString("D");
                    }
                }

                foreach (XmlNode t in xmlDocument.GetElementsByTagName("SiteID"))
                {
                    string siteId = t.FirstChild.InnerText;

                    if (siteId == "DUB")
                    {
                        declarationDocument.SiteId = ValidationStatus.InvalidSiteId.ToString("D");
                    }
                }

                declarationDocument.DocumentStructure = ValidationStatus.ValidStructure.ToString("D");

                return declarationDocument;
            }
            catch (Exception ex)
            {
                string message = ex.Message;    // Should be persisted to database
                declarationDocument.DocumentStructure = "";
                declarationDocument.DeclarationCommand = "";
                declarationDocument.SiteId = "";
                return declarationDocument;
            }
        }
        
        [WebMethod]
        public string UploadDocument(byte[] data, string fileName)
        {
            try
            {
                int fileNameExtension = fileName.LastIndexOf(".", StringComparison.Ordinal);
                string fileNameWithoutExtension = string.Empty;
                string uploadedFileName = string.Empty;
                const string fileExtension = ".xml";
                string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

                if (fileNameExtension >= 0)
                {
                    fileNameWithoutExtension = fileName.Substring(0, fileNameExtension);
                    uploadedFileName = String.Concat(fileNameWithoutExtension, timeStamp, fileExtension);
                }

                MemoryStream ms = new MemoryStream(data);
                FileStream fileStream = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath("~/XmlDocuments/") + uploadedFileName, FileMode.Create);
                ms.WriteTo(fileStream);
                ms.Close();
                fileStream.Close();
                fileStream.Dispose();
                return String.Concat(System.Web.Hosting.HostingEnvironment.MapPath("~/XmlDocuments/"), uploadedFileName);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
