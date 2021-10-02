using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.UsingDispose
{
    public class DataBaseCon : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Encerrando Conexão");
        }
    }
}
