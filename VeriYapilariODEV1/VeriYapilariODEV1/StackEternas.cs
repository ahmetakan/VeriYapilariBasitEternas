using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariODEV1
{
    public class StackEternas:IStack
    {
        public static string[] DoluStackler;
        public object[,] Cubuklar;
        private int top = -1;
        public int TotalCount = 0;
        
        private int Sayac = 0;
        public StackEternas()
        {
            Cubuklar = new object[8, 4];
            DoluStackler = new string[8];
        }
        
        public void Push(Boncuk _boncuk)
        {
            int random = _boncuk.RandomCubuk();

            top = Counter(Cubuklar, random, top, _boncuk).Item1;
            random = Counter(Cubuklar, random, top, _boncuk).Item2;

            if (top != 3)
            {
                if (IsEmpty())
                {
                    Cubuklar[random, ++top] = "W";
                }
                else
                {
                    Cubuklar[random, ++top] = _boncuk.Renk;

                    if (top == 3)
                    {
                        DoluStackler[Sayac] = random.ToString();
                        Sayac++;
                    }
                }

                TotalCount++;
                top = -1;
            }
        }

        public Boolean IsEmpty()
        {
            return (TotalCount == 0);
        }

        public (int,int) Counter(object[,] Stacks, int rnd, 
                                 int top, Boncuk boncuk)
        {

            while (Stacks[rnd, top + 1] != null)
            {
                top++;

                if (top == 3)
                {
                    top = -1;

                    rnd = boncuk.RandomCubuk();

                    break;
                }
            }

            return (top, rnd);
        }
    }
}
