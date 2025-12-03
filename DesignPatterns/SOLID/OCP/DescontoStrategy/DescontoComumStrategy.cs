namespace PadroesDeProjeto.DesignPatterns.SOLID.OCP.DescontoStrategy
{
    public class DescontoComumStrategy: IDescontoStrategy
    {
        public decimal ObterValorComDesconto(decimal valor)
        {
            return  valor;
        }
    }
}