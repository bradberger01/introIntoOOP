using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introIntoOOP
{
    class Dog
    {
        private string hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        public string Hairlength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int Runningspeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public Dog (string hairlength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairlength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }
        public void Run()
        {
            
        }
        public void Bark()
        {

        }
        public void Potty()
        {

        }
        public void Cuddle()
        {

        }
    }
}
