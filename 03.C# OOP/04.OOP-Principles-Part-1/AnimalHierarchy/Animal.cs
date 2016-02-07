namespace AnimalHierarchy
{
    using System;
    using System.Text;

    public abstract class Animal : ISound
    {
        // fields
        private uint age;

        private string name;

        private Gender sex;

        // constructor
        public Animal(string name, uint age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        // properties
        public uint Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public Gender Sex
        {
            get
            {
                return this.sex;
            }

            private set
            {
                this.sex = value;
            }
        }

        // methods
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
                if (animal is Cat)
                {
                    catsCount++;
                    catsAge += animal.age;
                }
                else if (animal is Dog)
                {
                    dogsCount++;
                    dogsAge += animal.age;
                }
                else if (animal is Frog)
                {
                    frogsCount++;
                    frogsAge += animal.age;
                }
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Average age of cats: {0:F2}", catsAge / catsCount));
            result.AppendLine(string.Format("Average age of dogs: {0:F2}", dogsAge / dogsCount));
            result.AppendLine(string.Format("Average age of frogs: {0:F2}", frogsAge / frogsCount));

            Console.WriteLine(result);
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return string.Format("I am {0}", this.name);
        }
    }
}