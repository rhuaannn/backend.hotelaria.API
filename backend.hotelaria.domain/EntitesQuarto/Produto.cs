public class Produto
{
    public Guid Id { get; set; } 
    public string Nome { get; private set; } = string.Empty;
    public double PrecoUnitario { get; private set; }
    public int QuantidadeInicial { get; private set; }
    public int QuantidadeDisponivel { get; private set; }

    public Produto(Guid id, string nome, double precoUnitario, int quantidadeInicial)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new Exception("Nome do produto não pode ser vazio");

        if (precoUnitario <= 0)
            throw new Exception("Preço unitário deve ser maior que zero");

        if (quantidadeInicial < 0)
            throw new Exception("Quantidade não pode ser negativa");

        Id = id;
        Nome = nome;
        PrecoUnitario = precoUnitario;
        QuantidadeInicial = quantidadeInicial;
        QuantidadeDisponivel = quantidadeInicial;
    }
    protected Produto() 
    {
    }

    public void RegistrarConsumoProduto(int quantidade)
    {
       if (quantidade > QuantidadeDisponivel)
            throw new Exception($"Quantidade indisponível. Disponível: {QuantidadeDisponivel}");
        

        QuantidadeDisponivel -= quantidade;
    }

    public double CalcularConsumo()
    {
        int quantidadeConsumida = QuantidadeInicial - QuantidadeDisponivel;
        return quantidadeConsumida * PrecoUnitario;
    }
}
