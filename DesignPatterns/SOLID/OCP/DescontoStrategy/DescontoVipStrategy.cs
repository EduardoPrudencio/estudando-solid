namespace PadroesDeProjeto.DesignPatterns.SOLID.OCP.DescontoStrategy
{
    public class DescontoVipStrategy : IDescontoStrategy
    {
        public decimal ObterValorComDesconto(decimal valor)
        {
            return  valor * 0.9M;
        }
    }
}