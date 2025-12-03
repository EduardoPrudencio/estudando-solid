

using PadroesDeProjeto.Domain;

namespace PadroesDeProjeto.DesignPatterns.SOLID.DIP
{
    public interface IPedidoRepository
    {
        void Salvar(Pedido pedido);
    }
}