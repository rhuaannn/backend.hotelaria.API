using backend.hotelaria.domain.Enum;
using backend.hotelaria.domain.Services;

public class Quarto
{
    public Guid Id { get; set; }  
    public int Numero { get; private set; }
    public int CapacidadeMaxima { get; private set; }
    public double ValorDiaria { get; private set; }
    public string Descricao { get; private set; } = string.Empty;
    public QuartoStatus Status { get; private set; } = QuartoStatus.Disponivel;
    public MiniBar MiniBar { get; private set; }
    public TipoQuartoEnum Tipo { get; private set; }

    public Quarto(Guid Id, int numero, int capacidadeMaxima, string descricao, double valorDiaria, MiniBar miniBar, TipoQuartoEnum tipo)
    {
        Id = Guid.NewGuid();
        Numero = numero;
        CapacidadeMaxima = capacidadeMaxima;
        Descricao = descricao;
        ValorDiaria = valorDiaria;
        MiniBar = miniBar;
        Tipo = tipo;
    }
    protected Quarto() { }

    public bool QuartoDisponivel() => Status == QuartoStatus.Disponivel;

    public void Reservar(int quantidadePessoas, DateTime dataReserva, TipoQuartoEnum tipoQuartoEnum)
    {
        
        if (dataReserva.Date < DateTime.Now.Date)
            throw new Exception("A data da reserva não pode ser no passado.");

        if (quantidadePessoas > CapacidadeMaxima)
            throw new Exception("Número de pessoas excede a capacidade máxima do quarto.");

        if (!QuartoDisponivel())
            throw new Exception("Quarto não está disponível para reserva.");

        Status = QuartoStatus.Reservado;
    }

    public void CheckIn(int quantidadePessoas)
    {
        if (Status != QuartoStatus.Disponivel && Status != QuartoStatus.Reservado)
            throw new Exception("Quarto não está disponível para check-in.");

        if (quantidadePessoas > CapacidadeMaxima)
            throw new Exception("Número de pessoas excede a capacidade máxima do quarto.");
       
        Reservar(quantidadePessoas, DateTime.Now, Tipo);
        Status = QuartoStatus.Ocupado;
    }

    public double CheckOut(TipoQuartoService tipoQuartoService)
    {
        if (Status != QuartoStatus.Ocupado)
            throw new Exception("Não é possível fazer check-out de um quarto que não está ocupado.");

        double tipoQuartoValor = tipoQuartoService.CalcularValorTipo(Tipo, ValorDiaria);
        double total = MiniBar.CalcularTotalConsumo() + tipoQuartoValor;

        Status = QuartoStatus.Disponivel;

        return total;
    }

    public void LiberarQuarto()
    {
        if (Status != QuartoStatus.Ocupado && Status != QuartoStatus.Reservado)
            throw new Exception("Quarto não está ocupado.");

        Status = QuartoStatus.Disponivel;
    }
}
