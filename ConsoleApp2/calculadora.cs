using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class calculadora
    {

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
        public  void exibirmenu()
        {
            Console.WriteLine("1-Adição\n" +
                              "2-subtração\n" +
                              "3-Multoplicação\n" +
                              "4-Divisão\n");
        }
        private int solicitaracaousuario()
        {
            int acao = -1;
            while (acao > 6 || acao < 0)
            {
                Console.WriteLine("qual ação voce deseja realizar");
                acao = int.Parse(Console.ReadLine());
                if (acao > 6 || acao <= 0)
                {
                    Console.WriteLine("digite um numero valido!!\n favor digitar un numero valido");
                }
            }
            return acao;
        }
        private void RealizarAcaorealizada(int acaoselecionada)
        {
            switch (acaoselecionada)
            {
                case 1:
                    adicao();
                    break;
                case 2:
                    subtracao();
                    break;
                case 3:
                    multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
            }


        }



        public void adicao()
        {
            Console.WriteLine("digite un numero");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("digite mais un numero");
            int num2=int.Parse(Console.ReadLine());

            int resultado=num + num2;
            Console.WriteLine($"o seu resulatdo e{resultado}");
        }
        public void subtracao()
        {
            Console.WriteLine("digite un numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("digite mais un numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num - num2;
            Console.WriteLine($"o seu resulatdo e  {resultado}");
        }

        public void multiplicacao()
        {
            Console.WriteLine("digite un numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("digite mais un numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num * num2;
            Console.WriteLine($"o seu resulatdo e {resultado}");
        }
        public void Divisao()
        { 
            Console.WriteLine("digite un numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("digite mais un numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num / num2;
            Console.WriteLine($"o seu resulatdo e {resultado}");
        }




    }
}
