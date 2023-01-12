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
                    case "*":
                        float resultAdd1 = firstNr * secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd1);
                        break;
                    case "/":
                        float resultAdd2 = firstNr / secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd2);
                        break;
                    case "-":
                        float resultAdd3 = firstNr - secondNr;
                        Console.WriteLine("Kahe numbri liitmisel on vastus: " + resultAdd3);
                        break;

                    default:
                        break;

                        //teha korrutamine, jagamine ja lahutamine
                }
            }
            catch (FormatException)//numbrilise v''rtuse kontroll
            {
                Console.WriteLine("Vale numbri formaat. Kas sa ei saa siis aru.");
                //throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
            }
        }
    }
}
