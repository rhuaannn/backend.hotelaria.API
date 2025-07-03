namespace backend.hotelaria.domain.Repositories
{
    public interface IQuartoRepository
    {
        Task <Quarto> ObterPorId(Guid id);
        Task<IEnumerable<Quarto>> ObterTodos();
        Task Adicionar(Quarto quarto);
        Task Atualizar(Quarto quarto);
        Task Remover(Guid id);

    }
}
