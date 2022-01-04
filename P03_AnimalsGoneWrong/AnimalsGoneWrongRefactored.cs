using System;
using System.Collections.Generic;
using System.Text;

namespace P03_AnimalsGoneWrong
{
    public class AnimalsGoneWrongRefactored
    {
        public class Animal
        {
            public string Breed { get; set; }

            public Animal(string breed)
            {
                Breed = breed;
            }

        }

        public class Walker : Animal
        {
            public Walker(string breed)
                : base(breed)
            {
                Breed = breed;
            }

            protected virtual void Walk()
            {
                Console.WriteLine("Waling");
            }
        }

        public class Swimmer : Animal
        {
            public Swimmer(string breed)
                : base(breed)
            {

            }
        }

        public class Cat : Walker
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

        public class Fish : Swimmer
        {
            public Fish(string breed)
                : base(breed)
            {

            }
        }
    }
}
