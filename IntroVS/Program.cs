// See https://aka.ms/new-console-template for more information
using System.Xml;

namespace IntroVS
{
    public abstract class IntroAbs
    {
        public abstract string run();
        public abstract void stop();
    }
    
    public class Program:IntroAbs
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public override string run()
        {     
            throw new NotImplementedException();
        }

        public override void stop()
        {
            throw new NotImplementedException();
        }
    }
}

