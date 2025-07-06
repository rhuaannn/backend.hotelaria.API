namespace backend.hotelaria.domain.ValueObjects
{
    public class Phone
    {
        public string Number { get; private set; } = string.Empty;
      
        protected Phone() 
        {
        }
        public Phone(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new Exception("numero nao pode ser vazio.");
            }
            if (!IsValidPhoneNumber(number))
            {
                throw new Exception("Formato inválido.");
            }
            Number = number;
        }
        public static bool IsValidPhoneNumber(string number)
        {
            return number.All(char.IsDigit) && number.Length >= 11;
        }
        public static implicit operator string(Phone phone) => phone.Number;
        public static implicit operator Phone(string number) => new Phone(number);
        public override string ToString() => Number;
    }
}
