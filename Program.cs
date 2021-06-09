using System;

namespace MyBanker
{
    class Program
    {
        private static string[] _firstNames = new string[] {
            "John",
            "Max",
            "Marc",
            "Peter",
            "Irwin",
            "David",
            "Patricia"
        };
        private static string[] _lastNames = new string[] {
            "Peterson",
            "Davidson",
            "Miller",
            "Gregory"
        };
        static void Main()
        {

            DisplayInfo();
            Console.ReadKey(true);
        }
        // Generate a new card
        static Card GenerateCard(string firstName, string lastName, Card.CardType cardType)
        {
            switch (cardType)
            {
                case Card.CardType.DebitCard:
                    return new DebitCard(LongRandom(10000000000000, 99999999999999, new Random()), LongRandom(1000000000, 9999999999, new Random()), _firstNames[new Random().Next(0, _firstNames.Length)] + " " + _lastNames[new Random().Next(0, _lastNames.Length)], DateTime.MaxValue);
                case Card.CardType.Mastercard:
                    return new Mastercard(LongRandom(10000000000000, 99999999999999, new Random()), LongRandom(100000000000, 999999999999, new Random()), _firstNames[new Random().Next(0, _firstNames.Length)] + " " + _lastNames[new Random().Next(0, _lastNames.Length)], DateTime.Now.AddYears(5));
                case Card.CardType.Maestro:
                    return new Maestro(LongRandom(10000000000000, 99999999999999, new Random()), LongRandom(100000000000000, 999999999999999, new Random()), _firstNames[new Random().Next(0, _firstNames.Length)] + " " + _lastNames[new Random().Next(0, _lastNames.Length)], DateTime.MaxValue);
                case Card.CardType.Visa:
                    return new Visa(LongRandom(10000000000000, 99999999999999, new Random()), LongRandom(1000000000, 9999999999, new Random()), _firstNames[new Random().Next(0, _firstNames.Length)] + " " + _lastNames[new Random().Next(0, _lastNames.Length)], DateTime.Now.AddYears(5));
                case Card.CardType.VisaElectron:
                    return new VisaElectron(LongRandom(10000000000000, 99999999999999, new Random()), LongRandom(1000000000, 9999999999, new Random()), _firstNames[new Random().Next(0, _firstNames.Length)] + " " + _lastNames[new Random().Next(0, _lastNames.Length)], DateTime.MaxValue);
            }
            return null;
        }
        //Magic
        // https://stackoverflow.com/questions/6651554/random-number-in-long-range-is-this-the-way \\
        static ulong LongRandom(ulong min, ulong max, Random rand)
        {
            ulong result = (ulong)rand.Next((int)(min >> 32), (int)(max >> 32));
            result = (result << 32);
            result = result | (ulong)rand.Next((int)min, (int)max);

            return result;
        }
        static void DisplayInfo()
        {

        }
    }
}
