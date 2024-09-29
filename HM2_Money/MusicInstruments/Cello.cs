using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MusicInstruments
{
    internal class Cello : MusicInstruments
    {
        public Cello(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Віолончель грає .......");
        }
    }
}
