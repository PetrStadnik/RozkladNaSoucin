using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozkladNaSoucin
{
    class Dvojce
    {
      

        public Dvojce ()
        {
            Console.WriteLine("Já jsem nová třída");
            
        }  

        public List<DvojceSoucinitelu> VypoctiDvojce(int x)
        {
            List<DvojceSoucinitelu> dvojceList = new List<DvojceSoucinitelu>();
            
            int y;
            double z = Math.Pow(x, (1.0/2.0));
            for (int p=1; p<= z ; p++)
            {
                if (x % p == 0)
                {
                    y = x / p;
                    dvojceList.Add(new DvojceSoucinitelu(p, y));
                }
            }
        

            return dvojceList;
        }
    }

    class DvojceSoucinitelu
    {
        public DvojceSoucinitelu(int cislo1, int cislo2){ Cislo1 = cislo1; Cislo2 = cislo2; }
        public int Cislo1 { get; set; }
        public int Cislo2 { get; set; }
    }
}
