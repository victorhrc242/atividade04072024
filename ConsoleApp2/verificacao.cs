using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_09072024
{
    public class verificacao
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
       

            public void iniciarsistema()
            {
                int acaoselecionada = -1;

                while (acaoselecionada != 0)
                {
                    exibirmenu();
                    acaoselecionada = solicitaracaousuario();
                    RealizarAcaorealizada(acaoselecionada);

                }
            }
            public void exibirmenu()
            {
                Console.WriteLine("1-Verificar se e multiplo\n" +
                                  "2-verifica se os dois são pares\n" +
                                  "3-verificar se a media e igual a 7\n" +
                                  "4-Sair\n");
            }
            private int solicitaracaousuario()
            {
                int acao = -1;
                while (acao > 6 || acao < 0)
                {
                    Console.WriteLine("qual ação voce deseja realizar");
                    acao = int.Parse(Console.ReadLine());
                    if (acao > 4 || acao <= 0)
                    {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido" +
                                    "1-Verificar se e multiplo\n" +
                              "2-verifica se os dois são pares\n" +
                              "3-verificar se a media e igual a 7\n" +
                              "0-Sair\n");
                    }
                }
                return acao;
            }
            private void RealizarAcaorealizada(int acaoselecionada)
            {
                switch (acaoselecionada)
                {
                    case 1:
                    verificarmultiplo();
                        break;
                    case 2:
                    verficarpares();
                        break;
                    case 3:
                    verficarmedia7();
                        break;
                
                }


            }

        private void verficarmedia7()
        {
            Console.WriteLine("digite un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero que vc quer saber se e multiplo");
            num2 = int.Parse(Console.ReadLine());
            if (num1 * num2 / 2 > 7)
            {
                Console.WriteLine("a media e maior que 7");
            }
            else
            {
                Console.WriteLine("a media e menor que 7");
            }


        }

        private void verficarpares()
        {
            Console.WriteLine("digite un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero que vc quer saber se e multiplo");
            num2 = int.Parse(Console.ReadLine());
            if (num1 % 2 == 0&& num2 % 2 == 0)
            {
                Console.WriteLine("esse numero e par"); 
            }
            else 
            {
                Console.WriteLine("esse numero não e par");
            }
           
         

        }

        private void verificarmultiplo()
        {
            Console.WriteLine("digite un numero");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero que vc quer saber se e multiplo");
            num2=int.Parse(Console.ReadLine());
            if (num1%num2==0)
            {
                Console.WriteLine("esse numero sera multiplo");
            }
            else
            {
                Console.WriteLine("esse numero não e multiplo");
            }
        }
    }
    }

