using System;

namespace Music
{
    public class Program
    {
        static void tune(Instrument i)
        {
            // ...
            i.Play();
        }
        static void tuneAll(Instrument[] e)
        {
            for (int i = 0; i < e.Length; i++)
                tune(e[i]);
        }


        public static void Main()
        {
           
            Instrument[] orchestra = new Instrument[5];
            int i = 0;
            // Upcasting during addition to the array:
            orchestra[i++] = new Guitar();
            orchestra[i++] = new Percussion();
            orchestra[i++] = new Stringed();
            orchestra[i++] = new ElectroGuitar();
            orchestra[i++] = new AcousticGuitar();
            tuneAll(orchestra);
        }
    }
}
