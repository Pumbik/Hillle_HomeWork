using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MusicInstruments
{
    internal class MusicInstruments
    {
        protected string Name {  get; private set; }
        protected string Description { get; private set; }
        protected string HistoryOfCreation {  get; private set; }

        public MusicInstruments(string name, string description, string history)
        {
            Name = name;
            Description = description;
            HistoryOfCreation = history;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук инструмента");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Назва інструменту: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Опис інструмента: {Description}");
        }

        public virtual void History()
        {
            Console.WriteLine($"Історія інструменту: {HistoryOfCreation}");
        }


    }
}
