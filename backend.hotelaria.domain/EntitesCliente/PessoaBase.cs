using backend.hotelaria.domain.ValueObjects;

namespace backend.hotelaria.domain.EntitesCliente
{
    public abstract class PessoaBase
    {
        public Guid Id { get;  set; }
        public string Nome { get; private set; } = string.Empty;
        public EmailAddress Email { get; private set; }
        public Phone Telefone { get; private set; }
        public Document Documento { get; private set; }

        protected PessoaBase(Guid id, string nome, EmailAddress email, Phone telefone, Document documento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Documento = documento;
        }
        protected PessoaBase()
        { 
        }
    }
}
