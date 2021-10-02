using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Classes
{
    public partial class Carro
    {
        //Metodo Construtor
        public Carro(int ano)
        {
            AnoFabricacao = ano;
            AnoModelo = ano;
            Console.WriteLine(AnoModelo);
        }

        public Carro()
        {
            Id = 50;
            Console.WriteLine("Construtor Vazio");
        }

        private Carro(string marca,
                     string modelo,
                     decimal potenciaMotor,
                     string combustivel,
                     int anoFabricacao,
                     int anoModelo,
                     string cor,
                     string tipo)
        {
            Marca = marca;
            Modelo = modelo;
            PotenciaMotor = potenciaMotor;
            Combustivel = combustivel;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            Cor = cor;
            Tipo = tipo;
        }
    }
}
