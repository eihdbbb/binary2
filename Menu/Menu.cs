using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beasts;

namespace Menu
{
    public class TopMenu
    {
        public TopMenu() { }

        public int MakeChoice(BeastsZoo beasts) {
            Console.WriteLine("Работа со списком зверей:");
            Console.WriteLine("1) добавить зверя(максимально здорового);  \n2) удалить зверя;  \n3) покормить зверя; \n4) подлечить зверя(+1); \n5) не кормить-не лечить;");
            Console.WriteLine("9) механизм уничтожения в случайном порядке;  \n0) выход без уничтожения");

            string s = InputNoEmpty();
            string cmd = s.Length >0 ? s.Substring(0, 1) : "" ;
            string name , type;

            if (cmd == "0")
            {
                Console.WriteLine("Окончание без уничтожения"); return 0;
            }
            if (cmd == "9")
            {
                Console.WriteLine("Уничтожение всех зверей в случайном порядке");
                beasts.EmptyZoo();
                return 0;
            }
            switch (cmd)
            {
                case "1": 
                    name = InputNoEmpty("введите кличку зверя: ");
                    type = InputNoEmpty("введите породу зверя (wolf, tiger, elephant, foxi, lion, bear): "); 
                    beasts.AddItem(name, type); break;
                case "2": 
                    name = InputNoEmpty("введите кличку зверя: "); 
                    beasts.RemoveItem(name); break;
                case "3": 
                    name = InputNoEmpty("введите кличку зверя: ");
                    beasts.DoEat(name); break;
                case "4": 
                    name = InputNoEmpty("введите кличку зверя: ");
                    beasts.DoHealth(name); break;
                case "5": 
                    name = InputNoEmpty("введите кличку зверя: "); 
                    beasts.DoBadly(name); break;
                default: Console.WriteLine("команда не опознана"); return 1;  
            }
            return 1;
        }

        private string InputNoEmpty(string s = "сделайте ввод строки не из пробелов: ")
        {
            string sIn;
            do
            {
                Console.Write(s);
                sIn = Console.ReadLine().Trim();
            } while (sIn.Length <= 0);
            return sIn;
        }
    }
}
