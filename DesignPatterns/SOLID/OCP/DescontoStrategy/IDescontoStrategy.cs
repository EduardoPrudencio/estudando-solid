namespace PadroesDeProjeto.DesignPatterns.SOLID.OCP.DescontoStrategy
{
    public interface IDescontoStrategy
    {
        decimal ObterValorComDesconto(decimal valor);
    }
}