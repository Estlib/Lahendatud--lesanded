namespace _2_Sulgudega_kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta, koos sisendikontrolliga ja sisendi normaliseerimisega, programm
            //küsib kasutajalt kolme tehet, esimene ja kolmas peaksid olema sulgude vahel ✅
            //kasutaja saab määrata igale tehtele märgi ✅
            //programm kuvab vastuse vastavalt tehete järjekorrale ✅

            Console.WriteLine("Sulgudega kalkulaator:");
            string[] tehterida = new string[7];
            Console.WriteLine("(arv tehe arv) tehe (arv tehe arv)");
            for (int i = 0; i < tehterida.Length; i++)
            {
                //string displayLine = "( ";
                //foreach (var input in tehterida)
                //{
                //    if (input.Contains("0123456789"))
                //    {

                //    }
                //}
                string sisestus = "";
                do
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"Palun sisesta {i + 1}. element, milleks on arv:");
                    }
                    else
                    {
                        Console.WriteLine($"Palun sisesta {i + 1}. element, milleks on tehe:");
                    }
                    sisestus = Console.ReadLine();
                    double checkSisestus = 0;


                    //if ((Double.TryParse(sisestus, out checkSisestus) == false) || (sisestus != "-" && sisestus != "*" && sisestus != "/" && sisestus != "+"))
                    //{
                    //    bool thisResult = Double.TryParse(sisestus, out checkSisestus);
                    //        Console.WriteLine(thisResult);
                    //    sisestus = "";
                    //    break;

                    //}
                    //else if (!Double.TryParse(sisestus, out checkSisestus) || (sisestus == "+" && sisestus == "-" && sisestus == "*" && sisestus == "/"))
                    //{
                    //    Console.WriteLine("ei ole arv, proovi uuesti");
                    //    sisestus = "";
                    //}
                    //else if (Double.TryParse(sisestus, out checkSisestus) || (sisestus != "+" && sisestus != "-" && sisestus != "*" && sisestus != "/"))
                    //{Mage
                    //    Console.WriteLine("ei ole tehtemärk, proovi uuesti");
                    //    sisestus = "";
                    //}
                    //else
                    //{
                    //    Console.WriteLine("eet pänt");
                    //    sisestus = "";
                    //}
                    if ((Double.TryParse(sisestus, out checkSisestus) == false))
                    {
                        sisestus = "";
                        //    Console.WriteLine("ei ole arv, proovi uuesti");
                        if ((sisestus == "+" && sisestus == "-" && sisestus == "*" && sisestus == "/"))
                        {
                            break;
                        }
                    }
                    if ((Double.TryParse(sisestus, out checkSisestus) == false))
                    {
                        sisestus = "";
                        //    Console.WriteLine("ei ole arv, proovi uuesti");

                    }

                } while (sisestus == "");


                tehterida[i] = sisestus;

            }

            double tehe = ÜksTehe(
                [
                ÜksTehe(
                    [tehterida[0], tehterida[1], tehterida[2]]
                    ).ToString(),

                    tehterida[3],

                ÜksTehe(
                    [tehterida[4], tehterida[5], tehterida[6]]
                    ).ToString()
                    ]
                );

            Console.WriteLine("vastus on " + tehe);

        }

        private static double ÜksTehe(string[] tehterida)
        {
            switch (tehterida[1])
            {
                case "+":
                    return Liitmine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                    break;
                case "-":
                    return Lahutamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                    break;
                case "*":
                    return Korrutamine(double.Parse(tehterida[0]), double.Parse(tehterida[2])); ;
                    break;
                case "/":
                    return Jagamine(double.Parse(tehterida[0]), double.Parse(tehterida[2]));
                    break;
                default:
                    return 0;
                    break;
            }

        }

        public static double Liitmine(double arv1, double arv2)
        {
            return arv1 + arv2;
        }
        public static double Lahutamine(double arv1, double arv2)
        {
            return arv1 - arv2;
        }
        public static double Korrutamine(double arv1, double arv2)
        {
            return arv1 * arv2;
        }
        public static double Jagamine(double arv1, double arv2)
        {
            return arv1 / arv2;
        }
    }
}
