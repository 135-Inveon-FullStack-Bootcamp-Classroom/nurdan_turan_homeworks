using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    interface Instrument
    {
        
        void Play(); // Automatically public
        string What(); // Automatically public
        void Adjust(); // Automatically public
    }
    // class Guitar implements interface Instrument
    class Guitar : Instrument
    {
        public virtual void Play()
        {
            System.Console.WriteLine("Guitar.Play()");
        }
        public virtual string What() { return "Guitar"; }
        public virtual void Adjust() { }
    }
    // class Percussion implements interface Instrument
    class Percussion : Instrument
    {
        public virtual void Play()
        {
            System.Console.WriteLine("Percussion.Play()");
        }
        public virtual string What()
        {
            return "Percussion";
        }
        public virtual void Adjust() { }
    }
    //extends
    class Battery : Percussion
    {
        public virtual void Play()
        {
            System.Console.WriteLine("Battery.Play()");
        }
        public virtual string What()
        {
            return "Battery";
        }
        public virtual void Adjust() {
            System.Console.WriteLine("Battery.Adjust()");
        }
    }
    // class Stringed implements interface Instrument
    class Stringed : Instrument
    {
        public virtual void Play()
        {
            System.Console.WriteLine("stringed.Play()");
        }
        public virtual string What() { return "stringed"; }
        public virtual void Adjust() { }
    }
    // Extends Stringed --> Flute and overwrite metot
    class Flute : Stringed
    {
        public virtual void Play()
        {
            System.Console.WriteLine("Flute.Play()");
        }
        public virtual string What() { return "Flute"; }
        public virtual void Adjust()
        {
            System.Console.WriteLine("Flute.Adjust()");
        }
    }

    // Extends Guitar --> ElectroGuitar and overwrite metot
    class ElectroGuitar : Guitar
    {
        public override void Play()
        {
            System.Console.WriteLine("ElectroGuitar.Play()");
        }
        public override void Adjust()
        {
            System.Console.WriteLine("ElectroGuitar.Adjust()");
        }
    }
    // Extends Guitar --> AcousticGuitar and overwrite metot
    class AcousticGuitar : Guitar
    {
        public override void Play()
        {
            System.Console.WriteLine("AcousticGuitar.Play()");
        }
        public override string What() { return "AcousticGuitar"; }
    }
   
}
