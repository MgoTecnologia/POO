using System;

namespace POO.Interfaces
{
    public abstract class Pagamento : IPagamento
    {
        public DateTime DataPagamento { get; private set; }
        public DateTime DataVencimento { get ; set ; }

        public Pagamento()
        {
            DataPagamento = DateTime.Now;
        }

        public abstract void Pagar();
        
    }
}
