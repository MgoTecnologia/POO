using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public class Veiculo
    {
        public Veiculo()
        {

        }

        public Veiculo(int id)
        {
            Id = id;
        }
        //        protected int Id { get; set; } Teste efetuado com Herança

        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var other = (Veiculo)obj;
            return Id == other.Id;
        }
        
        public static bool operator ==(Veiculo a, Veiculo b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            else
                return a.Equals(b);
        }
        public static bool operator != (Veiculo a, Veiculo b)
        {
            return !(a == b);
        }
    }
    //public class Veiculo : IEquatable<Veiculo>
    //{
    //    public Veiculo()
    //    {

    //    }

    //    public Veiculo(int id)
    //    {
    //        Id = id;
    //    }
    //    //        protected int Id { get; set; } Teste efetuado com Herança

    //    public int Id { get; set; }

    //    public bool Equals(Veiculo other)
    //    {
    //        return Id == other.Id;
    //    }
    //}
}
