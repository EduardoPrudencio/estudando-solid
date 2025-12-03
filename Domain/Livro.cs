using PadroesDeProjeto.DesignPatterns.SOLID.LSP;

namespace PadroesDeProjeto.Domain
{
    public class Livro : ItemFisico, ILivro
    {
        public double CalcularPeso()
        {
            return this.Peso;
        }

        public string GetIsbn()
        {
            throw new NotImplementedException();
        }
    }
}