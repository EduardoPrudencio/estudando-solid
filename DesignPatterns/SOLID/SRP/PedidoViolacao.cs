using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadroesDeProjeto.DesignPatterns.SOLID.SRP
{
    public class PedidoViolacao
    {
        public void AdicionarItem(string item)
        {
            // Lógica para adicionar item
        }

        public void DeletarItem(string item)
        {
            // Lógica para deletar item
        }

        public void CalcularTotal()
        {
            // Lógica para calcular o total do pedido
        }

        public void ValidarEstoque()
        {
            // Lógica para ir ao banco de dados checar estoque
        }

        public void SalvarPedido()
        {
            // Lógica para salvar o pedido no banco de dados SQL
        }

        public void EnviarEmailConfirmacao()
        {
            // Lógica para conectar no SMTP e enviar email
        }
    }
}