namespace Kriechrenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Kriechtier schnecke = new Schnecke(random);
            Kriechtier wurm = new Wurm(random);
            Kriechtier raupe = new Raupe(random);
            Kriechtier gottesanberetin = new Gottesanberetin(random);
            Kriechtier[] teilnehmer = new Kriechtier[] { schnecke, wurm, raupe, gottesanberetin };
            do
            { 
                Console.CursorTop = 0;
                Console.WriteLine(new string('#', 55));
                Console.WriteLine();

                foreach (Kriechtier kriecher in teilnehmer)
                {
                    kriecher.Kriechen();
                    kriecher.Visualisieren();
                }
                Console.WriteLine();
                Console.WriteLine(new string('#', 55));
                Thread.Sleep(500);

            }
            while(!teilnehmer.Any(t => t.Strecke >= 50));

        }
    }
}
