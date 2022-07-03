using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_logico_2
{
    internal class Program
    {

        private static string mesext(int mes)
        {
            string mesextenso;
            mesextenso = null;
            switch (mes)
            {
                case 1:
                    mesextenso = "Janeiro";
                    break;
                case 2:
                    mesextenso = "Fevereiro";
                    break;
                case 3:
                    mesextenso = "Março";
                    break;
                case 4:
                    mesextenso = "Abril";
                    break;
                case 5:
                    mesextenso = "Maio";
                    break;
                case 6:
                    mesextenso = "Junho";
                    break;
                case 7:
                    mesextenso = "Julho";
                    break;
                case 8:
                    mesextenso = "Agosto";
                    break;
                case 9:
                    mesextenso = "Setembro";
                    break;
                case 10:
                    mesextenso = "Outubro";
                    break;
                case 11:
                    mesextenso = "Novembro";
                    break;
                case 12:
                    mesextenso = "Dezembro";
                    break;
            }
            return mesextenso;
        }

        static void Main(string[] args)
        {

            int cidade, dia, mes, ano;
            string Cext;
            bool TF; 

            Console.Write(" Digite o numero da cidade que você quer:\n1 - Atibaia.\n2 - Brangança Paulista\n3 - Mairiporã\n4 - Nazaré\n5 - Terra Preta\n6 - Extrema\n7 - Vargem\nNúmero da cidade = ");
            cidade = int.Parse(Console.ReadLine());
            Cext = null;
            TF = false;

            switch (cidade)
            {
                case 1:
                    Cext = "Atibaia";
                    TF = true;
                    break;
                case 2:
                    Cext = "Bragança Paulista";
                    TF = true;
                    break;
                case 3:
                    Cext = "Mairiporã";
                    TF = true;
                    break;
                case 4:
                    Cext = "Nazaré";
                    TF = true;
                    break;
                case 5:
                    Cext = "Terra Preta";
                    TF = true;
                    break;
                case 6:
                    Cext = "Extrema";
                    TF = true;
                    break;
                case 7:
                    Cext = "Vargem";
                    TF = true;
                    break;
                default:
                    Console.WriteLine("insira um valor valido!");
                    TF = false;
                    break;
            }

            if (TF == true)
            {

                Console.WriteLine("digite uma data DD/MM/AAAA: ");
                var data = Convert.ToDateTime(Console.ReadLine());

                dia = data.Day;
                mes = data.Month;
                ano = data.Year;
                
                Console.WriteLine(Cext + ", " + dia + " de " + mesext(mes) + " de " + ano + ".");
                Console.ReadKey();
            }
            else
            {

                Console.ReadKey();

            }


        }
    }
}
