namespace backend.hotelaria.domain.ValueObjects
{
    public class EmailAddress
    {
        public string Address { get; private set; } = string.Empty;

        protected EmailAddress() 
        {
        }
        public EmailAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new Exception("Email não pode ser vazio.");
            }
            if (!IsValidEmail(address))
            {
                throw new Exception("Formado inválido.");
            }
            Address = address;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static implicit operator string (EmailAddress email) => email.Address;
        public static implicit operator EmailAddress(string email) => new EmailAddress(email);

        public override string ToString() => Address;
        
    }
}
