using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beasts;
using Menu;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            BeastsZoo beasts = new BeastsZoo();
            TopMenu menu = new TopMenu();

            beasts.AddItem(new Lion("simba"));
            beasts.AddItem(new Foxi("bony"));
            beasts.AddItem(new Wolf("bob"));
            beasts.AddItem(new Elephant("bem"));
            beasts.AddItem(new Bear("michael"));
            beasts.AddItem(new Tiger("Woods"));

            beasts.PrintAll();
            /*beasts.RemoveItem("bob");
            beasts.RemoveItem("michael");
            beasts.PrintAll();*/

            for (; menu.MakeChoice(beasts) != 0; )
                beasts.PrintAll();

                Console.ReadKey();
        }
    }
}
