using POO.ClasseAbstrata;
using POO.Classes;
using POO.Interfaces;
using POO.UsingDispose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe -> Tipo Complexo
            #region Classe Tipo Complexo  / Referencia
            //Pagamento pagto = new Pagamento();
            //pagto.Id = 5646;

            //Pagamento pagto2 = pagto;
            //pagto.Id = 1;
            //var pagto3 = pagto;

            //pagto3.Id = 5;
            //Console.ReadKey();
            //Console.WriteLine(pagto.Id);
            //Console.WriteLine(pagto2.Id);
            //Console.WriteLine(pagto3.Id);

            //Console.ReadKey();
            //int valor1 = 4;
            //int valor2 = valor1;
            //valor2 = 5;
            //Console.ReadKey();
            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            //Console.ReadKey();


            //Metodos
            //var carro = new Carro();
            //carro.DarPartida(false);
            //carro.DarPartida(true);
            ////var ExemploEstatica = new ExemploEstatica(); não pode criar instancia classe estática

            //Console.WriteLine(ExemploEstatica.RetornaNomeBancoDados());
            #endregion

            #region Interface/Classe Abstrata
            //Pagamento pagamento = new PagamentoCartao();
            //pagamento.Pagar();

            //Thread.Sleep(2000);

            //var pagamentoPix = new PagamentoPIX();
            //pagamentoPix.Pagar();

            #endregion

            #region Using Dispose
            //using (var db = new DataBaseCon()) 
            //{
            //    Console.WriteLine("Registro Criado Com Sucesso!");
            //}
            #endregion

            #region UpCast / DownCast
            //Veiculo veiculo = new Veiculo();
            //Carro carro = new Carro(2020);
            //Console.WriteLine(carro.AnoFabricacao);
            ////veiculo = carro;

            //carro = (Carro)veiculo;
            //Console.WriteLine(carro.AnoFabricacao);

            #endregion

            #region Comparar Objetos
            var veiculo = new Veiculo(1);
            var veiculo2 = new Veiculo(1);

            Console.WriteLine(veiculo == veiculo2);


            #endregion

            Console.ReadKey();

        }

    }
}
