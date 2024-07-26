namespace RechneriBtoB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Menu();
        }

        private static void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                string? wahl = "";
                Console.Clear();
                Console.WriteLine("Herzlich willkomen in KiB Rechner");
                Console.WriteLine("Was möchten Sie zu tun?");
                Console.WriteLine("1. Umwandeln Byte, KB, MB, GB, TB, PB nach KiB, MiB, GiB, TiB, PiB.");
                Console.WriteLine("2. Umwandeln Byte, KiB, MiB, GiB, TiB, PiB nach KB, MB, GB, TB, PB.");
                Console.WriteLine("3. Program ausschalten.");
                Console.WriteLine(" ");
                Console.WriteLine("Bitte geben ein Zahl mit Ihrem Wahl ein:");
                wahl = Console.ReadLine();
                int wahlInt = Convert.ToInt32(wahl);
                switch (wahlInt)
                {
                    case 1:
                        BtoIb();
                        break;
                    case 2:
                        Ibtob();
                        break;
                    case 3:
                        exit = true;
                        break;

                }
            }
        }
        private static void BtoIb()
        {
            Console.Clear();
            Console.WriteLine("Bitte geben Sie Eingang Einheiten ein");
            Console.WriteLine("1. Byte.");
            Console.WriteLine("2. KByte.");
            Console.WriteLine("3. MByte.");
            Console.WriteLine("4. GByte.");
            Console.WriteLine("5. TByte.");
            Console.WriteLine("6. PByte.");
            Console.WriteLine(" ");
            Console.WriteLine("Bitte geben Sie einen Zahl mit Ihrem Wahl ein:");
            string? wahl = Console.ReadLine();
            int wahlInt = Convert.ToInt32(wahl);
            Console.WriteLine("Bitte geben Sie Zahl dem Daten ein:");
            wahl = Console.ReadLine();
            double mengeByte = Convert.ToDouble(wahl);
            switch (wahlInt)
            {
                case 1:

                    break;
                case 2:
                    mengeByte = mengeByte * 1000;
                    break;
                case 3:
                    mengeByte = mengeByte * 1000 * 1000;
                    break;
                case 4:
                    mengeByte = mengeByte * 1000 * 1000 * 1000;
                    break;
                case 5:
                    mengeByte = mengeByte * 1000 * 1000 * 1000 * 1000;
                    break;
                case 6:
                    mengeByte = mengeByte * 1000 * 1000 * 1000 * 1000 * 1000;
                    break;
            }

            Console.WriteLine("Bitte geben Sie Ausgang Einheiten ein");
            Console.WriteLine("1. Byte.");
            Console.WriteLine("2. KiByte.");
            Console.WriteLine("3. MiByte.");
            Console.WriteLine("4. GiByte.");
            Console.WriteLine("5. TiByte.");
            Console.WriteLine("6. PiByte.");
            Console.WriteLine(" ");
            Console.WriteLine("Bitte geben Sie einen Zahl mit Ihrem Wahl ein:");
            wahl = Console.ReadLine();
            wahlInt = Convert.ToInt32(wahl);
            switch (wahlInt)
            {
                case 1:
                    wahl = "Byte";
                    break;
                case 2:
                    mengeByte = mengeByte / 1024;
                    wahl = "KiB";
                    break;
                case 3:
                    mengeByte = mengeByte / 1024 / 1024;
                    wahl = "MiB";
                    break;
                case 4:
                    mengeByte = mengeByte / 1024 / 1024 / 1024;
                    wahl = "GiB";
                    break;
                case 5:
                    mengeByte = mengeByte / 1024 / 1024 / 1024 / 1024;
                    wahl = "TiB";
                    break;
                case 6:
                    mengeByte = mengeByte / 1024 / 1024 / 1024 / 1024 / 1024;
                    wahl = "PiB";
                    break;
            }
            Console.WriteLine("Ergebnis= " + mengeByte + wahl);
            Console.ReadLine();
        }

        private static void Ibtob()
        {
            Console.Clear();

            Console.WriteLine("Bitte geben Sie Ausgang Einheiten ein");
            Console.WriteLine("1. Byte.");
            Console.WriteLine("2. KiByte.");
            Console.WriteLine("3. MiByte.");
            Console.WriteLine("4. GiByte.");
            Console.WriteLine("5. TiByte.");
            Console.WriteLine("6. PiByte.");
            Console.WriteLine(" ");
            Console.WriteLine("Bitte geben Sie einen Zahl mit Ihrem Wahl ein:");
            string? wahl = Console.ReadLine();
            int wahlInt = Convert.ToInt32(wahl);


            Console.WriteLine("Bitte geben Sie Zahl dem Daten ein:");
            wahl = Console.ReadLine();
            double mengeByte = Convert.ToDouble(wahl);
            switch (wahlInt)
            {
                case 1:

                    break;
                case 2:
                    mengeByte = mengeByte * 1000;
                    break;
                case 3:
                    mengeByte = mengeByte * 1000 * 1000;
                    break;
                case 4:
                    mengeByte = mengeByte * 1000 * 1000 * 1000;
                    break;
                case 5:
                    mengeByte = mengeByte * 1000 * 1000 * 1000 * 1000;
                    break;
                case 6:
                    mengeByte = mengeByte * 1000 * 1000 * 1000 * 1000 * 1000;
                    break;
            }


            Console.WriteLine("Bitte geben Sie Eingang Einheiten ein");
            Console.WriteLine("1. Byte.");
            Console.WriteLine("2. KByte.");
            Console.WriteLine("3. MByte.");
            Console.WriteLine("4. GByte.");
            Console.WriteLine("5. TByte.");
            Console.WriteLine("6. PByte.");
            Console.WriteLine(" ");
            Console.WriteLine("Bitte geben Sie einen Zahl mit Ihrem Wahl ein:");
            wahl = Console.ReadLine();
            wahlInt = Convert.ToInt32(wahl);

            switch (wahlInt)
            {
                case 1:
                    wahl = "Byte";
                    break;
                case 2:
                    mengeByte = mengeByte / 1024;
                    wahl = "KiB";
                    break;
                case 3:
                    mengeByte = mengeByte / 1024 / 1024;
                    wahl = "MiB";
                    break;
                case 4:
                    mengeByte = mengeByte / 1024 / 1024 / 1024;
                    wahl = "GiB";
                    break;
                case 5:
                    mengeByte = mengeByte / 1024 / 1024 / 1024 / 1024;
                    wahl = "TiB";
                    break;
                case 6:
                    mengeByte = mengeByte / 1024 / 1024 / 1024 / 1024 / 1024;
                    wahl = "PiB";
                    break;
            }
            Console.WriteLine("Ergebnis= " + mengeByte + wahl);
            Console.ReadLine();
        }
    }
}

