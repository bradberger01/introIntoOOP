using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introIntoOOP
{
    class Dog
    {
        private int hairLength;
        private int height;
        private int runningSpeed;
        private double weight;

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public Dog ()//default 
        {
            this.hairLength = 3;
            this.height = 3;
            this.runningSpeed = 80;
            this.weight = 220d;
        }
        public Dog(int hairLength, int height, int runningSpeed, double weight)//method overloading
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;

        }
        public void Run()
        {
            Console.WriteLine("I am running faster than you!!!");
        }
        public void Bark()
        {
            Console.WriteLine("Woof woof");
        }
        public void Potty()
        {

        }
        public void Cuddle(string name)
        {
            Console.WriteLine("{0} and the dog are cuddling...The dog is the big spoon", name);// {0} will be repaced by name
        }
    }
}
