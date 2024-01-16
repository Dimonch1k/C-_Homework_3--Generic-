namespace Generic
{
    class Program
    {
        public static void Main(string[] args)
        {
            IRepository<Person> pRepository = new PersonRepository();

            // Add 3 Person to the List
            Console.WriteLine(pRepository.Add(new Person { Name = "Jura", Age = 15, Id = 12345 }));
            Console.WriteLine(pRepository.Add(new Person { Name = "Andriy", Age = 21, Id = 13579 }));
            Console.WriteLine(pRepository.Add(new Person { Name = "John", Age = 44, Id = 24680 }));


            PrintList(pRepository.GetAll()); // Print all people in the List


            Console.WriteLine("Person by Id: \n");
            Person personById = pRepository.GetByID(13579); // Get the person by Id
            PrintPerson(personById);                        // Print person


            Console.WriteLine(pRepository.Remove(13579)); // Remove person from the List by Id


            Person removedPersonById = pRepository.GetByID(13579); // Get removed person by Id
            PrintPerson(removedPersonById);                        // Print person


            PrintList(pRepository.GetAll()); // Print all people
        }
        private static void PrintList(IEnumerable<Person> people)
        {
            Console.WriteLine("\nPeople in List:\n");
            foreach (Person person in people)
            {
                Console.WriteLine($"  Name: {person.Name}");
                Console.WriteLine($"  Age: {person.Age}");
                Console.WriteLine($"  Id: {person.Id}\n");
            }
            Console.WriteLine();
        }

        private static void PrintPerson(Person person)
        {
            if (person == null)
            {
                Console.WriteLine("There is no person with this Id!!!\n");
                return;
            }
            Console.WriteLine($"  Name: {person.Name} \n  Age: {person.Age} \n  Id: {person.Id}\n\n");
        }
    }
}