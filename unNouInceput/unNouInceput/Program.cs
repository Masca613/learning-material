using System;

namespace unNouInceput
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
            p.IcanSpeakSoWell("Muie PSD");
            Console.ReadLine();
        }

        public void IcanSpeakSoWell(string asd)
        {
            Console.WriteLine("Someone told me to say: " + asd);
        }
    }
}
