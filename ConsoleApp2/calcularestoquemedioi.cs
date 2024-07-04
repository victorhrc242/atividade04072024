using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class calcularestoquemedioi
    {

        public int estoqueminimo { get; set; }
        public int estoquemaximo { get; set; }
        public int estoquemedio { get; set; }

        public calcularestoquemedioi(int eminimo, int emaximo,int emedio) {

            estoquemaximo = emaximo;
            estoqueminimo = eminimo;
            estoquemedio=emedio;
            

        }

        public void calcular ()
            {

            estoquemedio = (estoqueminimo + estoquemaximo) / 2;

            Console.WriteLine(estoquemedio);
            

            }
       

    }
}
