namespace backend.hotelaria.domain.Interface
{
    public interface IQuartoRepository
    {
        Task <Quarto> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Quarto>> ObterTodosAsync();
        Task AdicionarAsync(Quarto quarto);
        Task AtualizarAsync(Quarto quarto);
        Task RemoverAsync(Guid id);

    }
}
