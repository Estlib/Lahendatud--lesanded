

using System.Drawing;

namespace _4_Mahukalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kirjuta programm mis
            //küsib kasutajalt kas ta tahab arvutada oma kasti mahtu, või õlivaadi mahtu
            //sisendite küsimiseks on oma meetod, mis ei lase programmil edasi liikuda, kuni vastus ei ole tühi, ega üks võimalikest valikutest.
            //selle tegemiseks annate meetodile parameetrina valikud listis kaasa ja .Contains abil saate kontrollida kas ta on olemas või mitte
            //kui programm teab kumba ta arvutab toimuvad järgmised tegevused
            //  kasti puhul, küsitakse kas kast on kuubik või risttahukas.
            //    - kuubiku puhul küsitakse küljepikkus, antakse parameetrina meetodile KuubiRuumala() kaasa,
            //      ning kuubiruumala tagastab double tüüpi andmena muutujasse tehte tulemuse. valem otsi internetist.
            //    - risttahuka puhul lühima ja pikima külje pikkust ning kõrgust. samamoodi arvutab parameetrite abil 
            //      meetod RisttahukaRuumala() tulemuse double andmena ja tagastab selle muutujasse.
            //  Tünni puhul, küsitakse kas ta tünn on kaanega või kaaneta.
            //    - Kui tal on kaas olemas, siis küsi selle paksust, kui ei ole, määra paksuseks ise 0
            //      Küsi kasutajalt ka tünni põhja läbimõõtu ja kõrgust ning arvuta SilindriRuumala()
            //      meetodiga kus parameetrid ka kaasas double tulemus mille tagastad muutujasse
            //      NB! kaane paksuse arvutad kõrgusest maha, sest kaas võtab õlitünni sees mingi ruumala enda poolt ära.
            //Kuva kasutajale tema ruumala tulemus peaprogrammis, mitte arvutatavates meetodites.
            decimal result = 0;

            List<string> options = new List<string>() {"kast", "tünn"};
            Console.WriteLine("Mille mahtu arvutada tahad?: ");
            string userSelection = GetAnswer(options);
            if (userSelection == "kast")
            {
                List<string> options2 = new List<string>() { "kuubik", "risttahukas" };
                Console.WriteLine("Kas ta on üks neist?: ");
                string userSelection2 = GetAnswer(options2);
                if (userSelection2 == "kuubik")
                {
                    Console.WriteLine("palun sisesta külje pikkus");
                    decimal side = GetAnswer();

                    result = RisttahukaRuumala(side, side, side);
                }
                else
                {
                    Console.WriteLine("palun sisesta pika külje pikkus");
                    decimal side = GetAnswer();
                    Console.WriteLine("palun sisesta lühikese külje pikkus");
                    decimal side2 = GetAnswer();
                    Console.WriteLine("palun sisesta kõrgus");
                    decimal height = GetAnswer();
                    result = RisttahukaRuumala(side, side2, height);
                }
            }
            else if (userSelection == "tünn")
            {
                decimal lidThickness = 0;
                List<string> options3 = new List<string>() { "jah", "ei" };
                Console.WriteLine("Kas su tünn on lahtine või mitte?: ");
                string userSelection3 = GetAnswer(options3);
                if (userSelection3 == "ei")
                {
                    Console.WriteLine("Palun kirjuta ka selle kaane paksus: ");
                    lidThickness = GetAnswer();
                }
                Console.WriteLine("Mis on tünni läbimõõt?");
                decimal barrelRadius = (GetAnswer()/2);
                Console.WriteLine("Kui kõrge on tünn?");
                decimal height = GetAnswer()-lidThickness;
                result = SilindriRuumala(barrelRadius, height);
            }
            Console.WriteLine($"Sinu {userSelection}i maht on {result} cm3");
        }

        private static decimal SilindriRuumala(decimal barrelRadius, decimal height)
        {
            double radius = (double)barrelRadius;
            return (decimal)(Math.PI * Math.Pow(radius, 2) * (double)height);
            //sitanikerdis
        }

        private static decimal RisttahukaRuumala(decimal a, decimal b, decimal c)
        {
            return a * b * c;
        }

        private static decimal GetAnswer()
        {
            decimal answer = 0;
            do
            {
                Console.Write("Kirjuta reaalne mõõt ->");
                answer = decimal.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (answer <= 0);
            return answer;
        }
        private static string GetAnswer(List<string> options)
        {
            Console.WriteLine("Valikus on:");
            foreach (string option in options) { Console.WriteLine(option); }
            string thisOption = "";
            do
            {
                Console.Write("Kirjuta sobiv sisestus ->");
                thisOption = Console.ReadLine().ToLower();
                Console.WriteLine();
            } while (!options.Contains(thisOption));
            return thisOption;
        }
    }
}
