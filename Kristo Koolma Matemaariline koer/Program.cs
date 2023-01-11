using System.Numerics;

namespace MatemaatilineKoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemaatiline Koer");

            Console.WriteLine("Palun sisesta esimene arv");
            float firstNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisesta tehe: ");
            string operation = Console.ReadLine();

            Console.WriteLine("Palun sisesta teine arv");
            float secondNr = int.Parse(Console.ReadLine());



            try
            {
                switch (operation)
                {
                    case "+":
                        float resultAdd = firstNr + secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd);
                        break;

                    case "-":
                        float resultSubtract = firstNr - secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus" + resultSubtract);
                        break;

                    case "*":
                        float resultMultiply = firstNr * secondNr;
                        Console.WriteLine("Kahe numbri korrutamise vastus on " + resultMultiply);
                        break;

                    case "/":
                        float resultDivide = firstNr / secondNr;
                        Console.WriteLine("Kahe numbri jagamise vastus on " + resultDivide);
                        break;

                    default:
                        break;
                        //teha korrutamine, jagamine ja lahutamine
                }
            }
            catch (FormatException)//numbrilise vartuse kontroll
            {
                Console.WriteLine("Vale numbri formaat.");
                //throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
            }
        }
    }
}