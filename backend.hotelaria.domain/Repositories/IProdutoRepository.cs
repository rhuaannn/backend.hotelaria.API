
namespace backend.hotelaria.domain.Repositories
{
    public interface IProdutoRepository
    {
        Task <Produto> ObterPorId(Guid id);
        Task <IEnumerable<Produto>> ObterTodos();
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
