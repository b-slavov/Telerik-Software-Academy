namespace AnimalHierarchy
{
    using System;
    using System.Text;

    public abstract class Animal : ISound
    {
        public Animal(string name, uint age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public uint Age { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public Species Species { get; set; }

        public static void PrintAverageAge(Animal[] animals)
        {
            float catsCount = 0f;
            uint catsAge = 0;

            float dogsCount = 0f;
            uint dogsAge = 0;

            float frogsCount = 0f;
            uint frogsAge = 0;

            foreach (var animal in animals)
            {
                if (animal.Species == Species.Cat)
                {
                    catsCount++;
                    catsAge += animal.Age;
                }
                else if (animal.Species == Species.Dog)
                {
                    dogsCount++;
                    dogsAge += animal.Age;
                }
                else if (animal.Species == Species.Frog)
                {
                    frogsCount++;
                    frogsAge += animal.Age;
                }
            }

            var result = new StringBuilder();
            result.AppendLine(string.Format("Average age of cats: {0:F2}", catsAge / catsCount));
            result.AppendLine(string.Format("Average age of dogs: {0:F2}", dogsAge / dogsCount));
            result.AppendLine(string.Format("Average age of frogs: {0:F2}", frogsAge / frogsCount));

            Console.WriteLine(result);
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return string.Format("I am {0}", this.Name);
        }
    }
}
