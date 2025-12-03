using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadroesDeProjeto.DesignPatterns.SOLID.OCP.DescontoStrategy
{
    public class DescontoPremiumStrategy:IDescontoStrategy
    {
        public decimal ObterValorComDesconto(decimal valor)
        {
            return  valor * 0.8M;
        }
    }
}