using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class dolar
    {
        public double cotacaoDolar { get; set; }
        public double valordedolar { get; set; }
        public double valo { get; set; }

        public void ler()
        {
            cotacaoDolar = 5.48;
            Console.WriteLine("qual ea a cotação do dolar?");
            cotacaoDolar=double.Parse(Console.ReadLine());
            Console.WriteLine("qual o valor do dolar que vc tem?");
            valordedolar=double.Parse(Console.ReadLine());

            valo=(cotacaoDolar*valordedolar);
            Console.WriteLine(valo);

        }

    }
}
