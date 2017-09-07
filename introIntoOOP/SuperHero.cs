using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introIntoOOP
{
    class SuperHero
    {
        private string alterEgo;
        private int curentPower;
        private int maxPower;
        private int numberOfBattles;

        public string AlterEgo
        {
            get { return this.alterEgo; }
            set { this.alterEgo = value; }
        }
        public int CurrentPower
        {
            get { return this.CurrentPower; }
        }
        public int MaxPower
        {
            get { return this.maxPower; }
        }
        public int NumberOfBattles
        {
            get { return this.numberOfBattles; }
        }
        public SuperHero()
        {
            this.alterEgo = "Bad Guy";
            this.curentPower = 5;
            this.maxPower = 5;
            this.numberOfBattles = 0;
        }
        public SuperHero(string alterEgo)
        {
            this.alterEgo = alterEgo;
            this.curentPower = 10;
            this.maxPower = 10;
            this.numberOfBattles = 0;
        }
        public void FightEvil()
        {
            if(this.curentPower < 2)
            {
                Console.WriteLine("I'm too weak to fight I need sleep!!");
            }
            else
            {
                this.numberOfBattles += 1;
                this.curentPower -= 2;
                Console.WriteLine("That was tough but I made it out ok. My current power is {0}", this.CurrentPower);
            }
            
        }
       public void Sleep()
        {
            Console.WriteLine("I feel better than ever!! I am at max power!!");
            this.curentPower = maxPower;

        }
        public void NextLevel()
        {
            if(numberOfBattles % 3 == 0)
            {
               this.maxPower += 10;
                this.curentPower = this.maxPower;

            }
            else
            {
                Console.WriteLine("You don't have enough battles yet");
            }
        }
    }
}
