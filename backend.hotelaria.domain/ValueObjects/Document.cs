namespace backend.hotelaria.domain.ValueObjects
{
    public class Document
    {
        public string DocumentNumber { get; private set; } = string.Empty;

        protected Document() 
        {
        }

        public Document(string documentNumber)
        {
            if (string.IsNullOrWhiteSpace(documentNumber))
            {
                throw new Exception("Documento não pode ser vazio.");
            }
            if (!IsValidDocument(documentNumber))
            {
                throw new Exception("Formato inválido.");
            }
            DocumentNumber = documentNumber;

        }

        public static bool IsValidDocument(string documentNumber)
        {
          
            if (documentNumber.Length == 11 && documentNumber.All(char.IsDigit))
            {
               
                return true;
            }
            
            if (documentNumber.Length == 14 && documentNumber.All(char.IsDigit))
            {
              
                return true;
            }
            return false;
        }
        public static implicit operator string(Document document) => document.DocumentNumber;
        public static implicit operator Document(string documentNumber) => new Document(documentNumber);
        public override string ToString() => DocumentNumber;
    }
}
