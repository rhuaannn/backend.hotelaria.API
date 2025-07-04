﻿using backend.hotelaria.domain.ValueObjects;

namespace backend.hotelaria.domain.EntitesCliente
{
    public class Cliente : PessoaBase
    {
        private readonly List<Dependente> _dependentes = new List<Dependente>();
        public IReadOnlyCollection<Dependente> Dependentes => _dependentes.AsReadOnly();

        public Cliente(Guid id, string nome, EmailAddress email, Phone telefone, Document documento)
            : base(id, nome, email, telefone, documento)
        {
        }
        protected Cliente() : base(Guid.NewGuid(), string.Empty, new EmailAddress(string.Empty), new Phone(string.Empty), new Document(string.Empty))
        {
        }
        public void AdicionarDependente(string nome, EmailAddress email, Phone telefone, Document documento, int idade)
        {
            if (_dependentes.Any(d => d.Documento.Equals(documento)))
               throw new Exception("Já existe dependente com este documento");
            if(_dependentes.Count >= 6)
                throw new Exception("Número máximo de dependentes atingido (6)");
            var dependente = new Dependente(Guid.NewGuid(), nome, email, telefone, documento, idade, this);
            _dependentes.Add(dependente);
        }
    }
}
