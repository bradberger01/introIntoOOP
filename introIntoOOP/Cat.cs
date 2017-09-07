using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introIntoOOP
{
    class Cat
    {//Fields
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;
        private bool isTired;
        private bool isThirsty;
    //Properties (like the middleman to get to the private fields)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //Constructors

        public Cat()
        {
            this.name = "Mittens";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        public Cat(int age)
        {
            this.age = age;
        }
        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry, bool isTired,bool isThirsty )
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
            this.isTired = isTired;
            this.isThirsty = isThirsty;
        }
        public int Age
        {
            get { return this.age; }
        }
        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
                Console.WriteLine("I am stuffed");
            }
            else if(!isHungry)
            {
                Console.WriteLine("I'm good. No food for me");
            }
        }
        public void Run()
        {
            Console.WriteLine("I am running really fast!!");
            this.isHungry = true;
        }
        public void Drink()
        {
           if(isThirsty)
            {
                isThirsty = false;
                Console.WriteLine("I've had enough water");
            } 
           else if(!isThirsty)
            {
                Console.WriteLine("No water for me, thanks.");


            }
        }
        public void Sleep()
        {
            if(isTired)
            {
                isTired = false;
                Console.WriteLine("Let's stay up and party!");
            }
            else if(!isTired)
            {
                Console.WriteLine("I'm tired. Time to get some shut eye");
                this.isHungry = false;
            }
        }
        public void Talk()
        {
            Console.WriteLine("My name is {0} and yes I can talk", this.name);
        }
    }
}
