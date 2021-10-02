using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ClasseAbstrata
{
    public class PagamentoPIX : Pagamento
    {
        public override void Pagar()
        {
            Console.WriteLine($"Pix Enviado {DataPagamento}");
        }
    }
}
