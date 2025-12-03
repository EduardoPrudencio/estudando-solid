

using PadroesDeProjeto.DesignPatterns.SOLID.DIP;

namespace PadroesDeProjeto.Domain.Services
{
    public class PedidoService
    {
        IPedidoRepository _pedidoRepository;
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public void SalvrPedido(Pedido pedido)
        {
            _pedidoRepository.Salvar(pedido);
        }
    }
    
}