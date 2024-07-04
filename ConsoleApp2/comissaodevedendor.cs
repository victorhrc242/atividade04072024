using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class comissaodevedendor
    {

        public int id { get; set; }
        public int codigopeça { get; set; }
        public int quantidadevendida { get; set; }
        public double precoproduto { get; set; }
        
        public comissaodevedendor(int i,int c,int q,double p)
        {
            id= i;
            codigopeça= c;
            quantidadevendida= q;
            precoproduto= p;
        }
        public  void somarpreco()
        {
            precoproduto = (quantidadevendida * precoproduto);
        }
        public void somarcomissao()
        {
            double total = precoproduto =(precoproduto * 0.5);
            Console.WriteLine(total);
        }
    }
    
}
