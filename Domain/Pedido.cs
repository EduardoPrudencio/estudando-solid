using PadroesDeProjeto.DesignPatterns.SOLID.LSP;
using PadroesDeProjeto.Domain.Enum;

namespace PadroesDeProjeto.Domain
{
    public class Pedido:IPedito
    {
        public Guid Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public List<Item>? Itens { get; set; }
        public PedidoStatus Status { get; set; }
        public void AdicionarItem(Item item)
        {
            if(Itens == null) Itens = new List<Item>();
            Itens.Add(item);
        }

        public decimal CalcularValorTotal()
        {
            if(Itens == null) return 0;
            return Itens.Sum( t => t.Preco );
        }

        public string GetEnderecoEntrega()
        {
            throw new NotImplementedException();
        }
    }
}