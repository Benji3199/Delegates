using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkeerslichten
{
    class Program
    {
        static void Main(string[] args)
        {
            Verkeersplein verkeersplein = new Verkeersplein();
            Verkeerslicht v1 = new Verkeerslicht(1, LichtKleur.Rood);
            Verkeerslicht v2 = new Verkeerslicht(2, LichtKleur.Groen);
            Verkeerslicht v3 = new Verkeerslicht(3, LichtKleur.Rood);
            Verkeerslicht v4 = new Verkeerslicht(4, LichtKleur.Groen);

            verkeersplein.SubscribeVerkeerslicht(v1.SwitchLicht);
            verkeersplein.SubscribeVerkeerslicht(v2.SwitchLicht);
            verkeersplein.SubscribeVerkeerslicht(v3.SwitchLicht);
            verkeersplein.SubscribeVerkeerslicht(v4.SwitchLicht);

            while (true)
            {
                //Event versturen
                verkeersplein.PublishLichtenOmswitchen();
                Console.WriteLine(verkeersplein.ToString());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
