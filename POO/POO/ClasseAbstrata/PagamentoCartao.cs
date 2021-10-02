using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ClasseAbstrata
{
    public class PagamentoCartao : Pagamento
    {
        public override void Pagar()
        {
            Console.WriteLine($"Pagamento Autorizado - {DataPagamento}");
        }
    }
}
