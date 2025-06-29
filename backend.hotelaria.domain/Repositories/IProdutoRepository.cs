
namespace backend.hotelaria.domain.Repositories
{
    public interface IProdutoRepository
    {
        Produto ObterPorId(Guid id);
        IEnumerable<Produto> ObterTodos();
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Guid id);
    }
}
