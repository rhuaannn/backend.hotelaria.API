namespace backend.hotelaria.domain.Repositories
{
    public interface IQuartoRepository
    {
        public Quarto ObterPorId(Guid id);
        public IEnumerable<Quarto> ObterTodos();
        public void Adicionar(Quarto quarto);
        public void Atualizar(Quarto quarto);
        public void Remover(Guid id);

    }
}
