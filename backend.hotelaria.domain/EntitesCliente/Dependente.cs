using backend.hotelaria.domain.ValueObjects;
using System.Text.Json.Serialization;

namespace backend.hotelaria.domain.EntitesCliente
{
    public class Dependente : PessoaBase
    {
        public int Idade { get; private set; }

        [JsonIgnore]
        public Cliente Cliente { get; }
        public Dependente(Guid id, string nome, EmailAddress email, Phone telefone, Document documento, int idade, Cliente cliente)
            : base(id, nome, email, telefone, documento)
        {
            if(Idade < 0)
                throw new ArgumentException("Idade não pode ser negativa");
            Idade = idade;
            Cliente = cliente;
        }

        protected Dependente() : base(Guid.NewGuid(), string.Empty, new EmailAddress(string.Empty), new Phone(string.Empty), new Document(string.Empty))
        {
          
        }
    }
}
