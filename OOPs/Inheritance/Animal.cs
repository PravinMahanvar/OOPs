/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Inheritance

    public class Animal
    {
        protected string types;
        protected string Animalname;

        public Animal(string types, string Animalname)
        {
            this.types = types;
            this.Animalname = Animalname;
        }

        public virtual string display()
        {
            return $"{types} {Animalname}";
        }
    }

    public class Dog : Animal
    {
        private string colour;
        private string dogname;

        public Dog(string colour, string dogname, string types, string Animalname) : base(types, Animalname)
        {
            this.colour = colour;
            this.dogname = dogname;
        }

        public override string display()
        {
            return $"Dog={colour}- {dogname}-{types} {Animalname}";
        }


    }
    public class Cat : Animal
    {
        private string colour;
        private string catname;

        public Cat(string colour, string catname):base(types,Animalname)
        {
            this.colour = colour;
            this.catname = catname;
        }
        public override string display()
        {
            return $"{colour} {catname} {types} {Animalname}";
        }
    }
}       
*/