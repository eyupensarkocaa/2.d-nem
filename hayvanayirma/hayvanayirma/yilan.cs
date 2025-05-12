using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanayirma
{
    internal class yilan : IEat, ISound, IWalk

    {
        public void IEat()
        {
            Console.WriteLine("Yılan yemek yer");
        }

        public void ISound()
        {
            Console.WriteLine("Yılan ses çıkarır");
        }

        public void IWalk()
        {
            Console.WriteLine("Yılan yürüyemez");
        }
    }
}
