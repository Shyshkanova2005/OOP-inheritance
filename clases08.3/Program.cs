using System;

namespace clases08._3
{
    class Musicallinstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Playing a musical instrument");
        }
    }
    class Guitar : Musicallinstrument
    {
        public override void Play()
        {
            Console.WriteLine("Playing a guitar");
        }
    }

    class Piano : Musicallinstrument
    {
        public override void Play()
        {
            Console.WriteLine("Playing a piano");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musicallinstrument[] musinst = new Musicallinstrument[]
            {
                new Guitar(),
                new Piano()
            };

            foreach (Musicallinstrument instrument in musinst)
            {
                instrument.Play();

            }
        }
    }
}
