using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Day2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Jungler jungle = new Jungler();
            jungle.description();

            MyTopJungler champ = new MyTopJungler();
            champ.displayName();

            string abilityPassive;
            string abilities = champ.abilityName("Jaws of the Beast", "Blood Hunt", "Primal Howl", "Infinite Duress", out abilityPassive);
            Console.WriteLine(abilities);

            Console.ReadLine();
        }
    }

    class Champions
    {
        public virtual void description() 
        {
            Console.WriteLine("This is a Champion.");
        }
    }

    class Jungler : Champions
    {
        public override void description()
        {
            Console.WriteLine("This is a Jungler.");
        }
    }

    class MyTopJungler : Jungler
    {
        private string name;

        public string getChampionName()
        {
            return name;
        }

        public void setChampionName(string newName)
        {
            name = newName;
        }

        public void displayName()
        {
            Console.WriteLine("I am Warwick");
        }

        public string abilityName(string abilityQ)
        {
            return abilityQ;
        }

        public string abilityName(string abilityQ, string abilityW)
        {
            return abilityQ + ", " + abilityW;
        }

        public string abilityName(string abilityQ, string abilityW, string abilityE)
        {
            return abilityQ + " - " + abilityW + " - " + abilityE;
        }

        public string abilityName(string abilityQ, string abilityW, string abilityE, string abilityR, out string abilityPassive)
        {
            abilityPassive = "Eternal Hunger";
            return abilityQ + " -- " + abilityW + " -- " + abilityE + " -- " + abilityR;
        }
    }


}
