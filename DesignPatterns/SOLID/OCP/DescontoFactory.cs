
using PadroesDeProjeto.DesignPatterns.SOLID.OCP.DescontoStrategy;
using PadroesDeProjeto.Domain.Enum;

namespace PadroesDeProjeto.DesignPatterns.SOLID.OCP
{
    public class DescontoFactory
    {
        public IDescontoStrategy ObterCalculadorDeDesconto(TipoCliente tipoCliente)
        {
            switch (tipoCliente)
            {
                case TipoCliente.Comum:
                    return new DescontoComumStrategy();
                 case TipoCliente.Vip:
                    return new DescontoVipStrategy();
                 case TipoCliente.Premium:
                    return new DescontoPremiumStrategy();       
                default:
                throw new NotImplementedException();
            }
        }
    }
}