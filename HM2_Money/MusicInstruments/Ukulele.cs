using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MusicInstruments
{
    internal class Ukulele : MusicInstruments
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Укулеле грає бринь...бринь...бринь");
        }
    }
}
