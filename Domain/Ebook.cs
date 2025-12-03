
using PadroesDeProjeto.DesignPatterns.SOLID.LSP;

namespace PadroesDeProjeto.Domain
{
    public class Ebook : Item, ILivro
    {
        public string GetIsbn()
        {
            throw new NotImplementedException();
        }
    }
}