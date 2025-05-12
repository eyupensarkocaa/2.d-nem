using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanayirma
{
    internal class kopek : IEat, ISound, IWalk
    {
        public void IEat()
        {
            Console.WriteLine("Köpek yemek yer");
        }

        public void ISound()
        {
            Console.WriteLine("Köpek ses çıkarır");
        }

        public void IWalk()
        {
            Console.WriteLine("Köpek yürür");
        }
    }
}
