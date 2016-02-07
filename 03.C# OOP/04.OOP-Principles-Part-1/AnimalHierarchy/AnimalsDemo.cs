namespace AnimalHierarchy
{
    public class AnimalsDemo
    {
        public static void Main()
        {
            // declare some cats
            var kittenTea = new Kitten("Tea", 2);
            var tomcatRoko = new Tomcat("Roko", 4);
            var kittenCeca = new Kitten("Ceca", 1);

            // declare some dogs
            var dogBalkan = new Dog("Balkan", 3, Gender.Male);
            var dogSara = new Dog("Sara", 2, Gender.Female);

            // declare some frogs
            var frogKermit = new Frog("Kermit", 1, Gender.Male);
            var frogCarlotta = new Frog("Carlotta", 2, Gender.Female);

            // calculate average age
            var animals = new Animal[] { kittenTea, tomcatRoko, kittenCeca, dogBalkan, dogSara, frogKermit, frogCarlotta };

            Animal.PrintAverageAge(animals);

            // test sound of animals
            foreach (var animal in animals)
            {
                animal.ProduceSound();
            }
        }
    }
}