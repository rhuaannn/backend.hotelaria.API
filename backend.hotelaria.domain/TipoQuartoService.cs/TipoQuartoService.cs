using backend.hotelaria.domain.Enum;

namespace backend.hotelaria.domain.Services
{
    public class TipoQuartoService
    {
        public double CalcularValorTipo(TipoQuartoEnum tipo, double valorDiaria)
        {
           if(tipo == TipoQuartoEnum.Solteiro)
            {
                return valorDiaria * 1.0;  
            }
            else if(tipo == TipoQuartoEnum.Casal)
            {
                return valorDiaria * 1.2;  
            }
            else if(tipo == TipoQuartoEnum.Luxo)
            {
                return valorDiaria * 1.5; 
            }
            else
            {
                throw new Exception("Tipo de quarto inválido.");
            }

            
            
        }
    }
}
