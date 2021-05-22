using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariODEV1
{
    public class Boncuk
    {
        public object Renk { get; set; }

        public int RandomCubuk()
        {
            System.Threading.Thread.Sleep(10);
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int random = rnd.Next(0, 8);

            for (int i = 0; i < 8; i++)
            {
                while (StackEternas.DoluStackler[i] == random.ToString())
                {
                    random = rnd.Next(0, 8);
                    i = 0;
                }
            }

            return random;
        }
    }
}
