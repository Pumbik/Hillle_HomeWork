using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MusicInstruments
{
    internal class Violin : MusicInstruments
    {
        public Violin(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Sound()
        {
            //base.Sound();
            Console.WriteLine("Скрипка грає ля-ля-ля...");
        }
    }
}
