namespace GeneratePerson
{
    internal class Generator
    {
        public Person GeneratePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "Man";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "Woman";
                newPerson.Gender = Gender.Female;
            }

            return newPerson;
        }
    }
}