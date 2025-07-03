
namespace backend.hotelaria.domain.Repositories
{
    public interface IProdutoRepository
    {
        public Produto ObterPorId(Guid id);
        public IEnumerable<Produto> ObterTodos();
        public void Adicionar(Produto produto);
        public void Atualizar(Produto produto);
        public void Remover(Guid id);
    }
}
