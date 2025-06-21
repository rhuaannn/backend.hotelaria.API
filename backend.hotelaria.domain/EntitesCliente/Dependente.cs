using backend.hotelaria.domain.ValueObjects;

namespace backend.hotelaria.domain.EntitesCliente
{
    public class Dependente : PessoaBase
    {
        public int Idade { get; private set; }
        public Cliente Cliente { get; private set; }
        public Dependente(Guid id, string nome, EmailAddress email, Phone telefone, Document documento, int idade, Cliente cliente)
            : base(id,nome, email, telefone, documento)
        {
            Idade = idade;
            Cliente = cliente;
        }

        protected Dependente() : base()
        {
        }
    }
}
