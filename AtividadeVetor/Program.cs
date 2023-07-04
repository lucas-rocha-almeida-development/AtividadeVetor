using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeVetor {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            //[array] new double [quantidade de elementos,basicamente a quantidade que sera disponibiliza]
            // na memoria ex: foi digitado 3 , ou seja , indices 0,1,2 = 3 indicies
            double[] vect = new double[N]; //quantidade de vetores N que sera digitado

            for (int i = 0; i < N; i++) {
                //criamos uma variavel int que recebe 0, e verificaremos condiçoes e sendo true, sera
                //executado o comando dentro do for, logo depois ira ser feito o incremento para variavel
                //i , novamente condição sendo true ira executar, so ira parar quando condição for false.
                //vamos acessar posição do vetor
                //posição ira começar com 0,1,2 conforme incremetos (N)
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);



            }
            //vamos somar todas vetores/alturas
            double soma = 0.0;
            for (int i =0; i < N; i++) {

                soma += vect[i];
            }
            //variavel de tirar a media dos valores da soma / N
            double media = soma/ N;

            Console.WriteLine("Altura Media:" + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
