using backend.hotelaria.domain.EntitesCliente;

namespace backend.hotelaria.domain.Repositories
{
    public interface IClienteRepository
    {
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Remover(Guid id);
    }
}
