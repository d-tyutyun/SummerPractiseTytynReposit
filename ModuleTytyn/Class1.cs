using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ModuleTytyn
{
    public class Class1
    {
        int Num; // Number
        int Step; // Step
        int Mod; // Modul
        bool sign,tmp=false; // sign

        public Class1(int num,int step,int mod, bool sgn) // constructor
        {
            Num = num;
            Step = step;
            Mod = mod;
            sign = sgn;
        }

        public string ModeleRes() //operation
        {
            if (tmp)
            {
                for (;;)
                {
                    if (Num > Mod)
                        Num -= Mod;
                    else
                        break;
                }

                Num = Num * Num * Num;
                Step /= 3;

                for (int i = 0; i < 3; i++)
                {
                    Num += Mod;
                }
            }
            return (BigInteger.ModPow(Num, Step, Mod)).ToString();
        }
    }
}
