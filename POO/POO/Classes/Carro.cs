using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    //Classe Selada -> Não Pode Ser Pai De Outra Classe
    public sealed partial class Carro : Veiculo
    {
        #region Atributos
        //Marca
        public string Marca { get; set; }
        //Modelo
        public string Modelo { get; set; }
        //PotenciaMotor
        public decimal PotenciaMotor { get; set; }
        //Combustivel
        public string Combustivel { get; set; }
        //Ano Fabricacap
        public int AnoFabricacao { get; set; }
        //Ano Modelo
        public int AnoModelo { get; set; }
        //Cor
        public string Cor { get; set; }
        //Tipo
        public string Tipo { get; set; }
        #endregion

        private void DarPartida() 
        {
            Console.WriteLine($"Carro Ligado id - {Id}");
        }

        public void DarPartida(bool possuiCombustivel) 
        {
            if (possuiCombustivel)
                DarPartida();
            else
                Console.WriteLine("Carro sem combustível");

        }
    }
}
