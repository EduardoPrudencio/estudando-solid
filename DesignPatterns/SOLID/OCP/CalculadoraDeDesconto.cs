using PadroesDeProjeto.DesignPatterns.SOLID.OCP.DescontoStrategy;
using PadroesDeProjeto.Domain;

namespace PadroesDeProjeto.DesignPatterns.SOLID.OCP
{
    public class CalculadoraDeDesconto
    {
        public decimal Calcular(Pedido pedido, IDescontoStrategy descontoStrategy)
        {
            return descontoStrategy.ObterValorComDesconto(pedido.CalcularValorTotal());
        }
    }
}