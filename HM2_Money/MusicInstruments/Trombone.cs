using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MusicInstruments
{
    internal class Trombone : MusicInstruments
    {
        public Trombone(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Sound()
        {
            //base.Sound();
            Console.WriteLine("Тромбон грає бу-бу-бу...");
        }
    }
}
