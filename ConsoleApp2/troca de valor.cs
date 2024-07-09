using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class troca_de_valor
    {
        public int iten { get; set; }
        public int iten2 { get; set; }
        public void ctr() {

            Console.WriteLine("digite un valor");
            iten=int.Parse(Console.ReadLine());
            Console.WriteLine("digite un segundo valor");
             iten2=int.Parse(Console.ReadLine());
            Console.WriteLine($"iten A:{iten}\n");
            Console.WriteLine($"iten B:{iten2}");
        }
        public void trocarvalores()
        {
           
        }
       


    }
}
