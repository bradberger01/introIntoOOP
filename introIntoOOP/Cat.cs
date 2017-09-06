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
        public Cat(string name, string furColor, int furLength, int age, bool isMale)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;

        }
        public int Age
        {
            get { return this.age; }
        }
    }
}
