using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanayirma
{
    internal class kedi : IEat, ISound, IWalk
    {
        public void IEat()
        {
            Console.WriteLine("Kedi yemek yer");
        }

        public void ISound()
        {
            Console.WriteLine("Kedi ses çıkarır");
        }

        public void IWalk()
        {
            Console.WriteLine("Kedi yürür");
        }
    }
}
