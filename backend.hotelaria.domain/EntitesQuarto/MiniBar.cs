public class MiniBar
{
    private readonly List<Produto> _produtos = new List<Produto>();
    public IReadOnlyCollection<Produto> Produtos => _produtos.AsReadOnly();

    public MiniBar(List<Produto> produtos)
    {
        if (produtos == null || !produtos.Any())
            throw new Exception("O MiniBar precisa ter ao menos um produto.");

        _produtos.AddRange(produtos);
    }
    public void RegistrarConsumo(string nomeProduto, int quantidade)
    {
        var produto = _produtos.FirstOrDefault(p => p.Nome == nomeProduto);
        if (produto == null)
            throw new Exception("Produto não encontrado no MiniBar.");

        produto.RegistrarConsumo(quantidade);
    }
    public double CalcularTotalConsumo()
    {
        return _produtos.Sum(p => p.CalcularConsumo());
    }
}
