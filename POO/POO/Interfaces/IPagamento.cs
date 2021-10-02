using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    public interface IPagamento
    {
        DateTime DataVencimento { get; set; }
        void Pagar();

    }
}
