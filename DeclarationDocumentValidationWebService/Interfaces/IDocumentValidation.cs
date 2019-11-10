using DeclarationDocumentValidationWebService.Classes;

namespace DeclarationDocumentValidationWebService.Interfaces
{
    public interface IDocumentValidation
    {
        DeclarationDocument ValidateDocument(string doc);
        string UploadDocument(byte[] data, string fileName);
    }
}
