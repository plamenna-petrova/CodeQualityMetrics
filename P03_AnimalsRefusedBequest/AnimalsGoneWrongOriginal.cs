using System;
using System.Collections.Generic;
using System.Text;

namespace P03_AnimalsGoneWrong
{
    public class AnimalsGoneWrongOriginal
    {
        public class Animal
        {
            public string Breed { get; set; }

            public Animal(string breed)
            {
                Breed = breed;
            }

            protected virtual void Walk() 
            {
                Console.WriteLine("An animal is walking");
            }
        }

        public class Cat : Animal 
        {
            public string Name { get; set; }

            public Cat(string breed, string name)
                : base(breed)
            {
                Name = name;
            }

            protected override void Walk()
            {
                Console.WriteLine($"The cat {Name} is walking");
            }
        }

        public class Fish : Animal 
        {
            public Fish(string breed)
                : base (breed)
            {

            }

            protected override void Walk()
            {
                throw new NotImplementedException();
            }
        }
    }
}
