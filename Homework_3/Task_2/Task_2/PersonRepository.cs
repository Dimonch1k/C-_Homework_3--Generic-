namespace Generic
{
    public class PersonRepository : IRepository<Person>
    {
        private List<Person> people = new List<Person>();

        public string Add(Person person) // Add person to the List
        {
            people.Add(person);
            return "The person was added to the List.";
        }

        public Person GetByID(int id) // Return the Person by Id
        {
            return people.FirstOrDefault(p => p.Id == id);
        }

        public string Remove(int id) // Remove person by id
        {
            if (isNull()) return "The list is empty!!!\n";  // if List is empty

            Person removePerson = people.FirstOrDefault(p => p.Id == id);
            if (removePerson != null)
            {
                people.Remove(removePerson);
                return "The person removed from List.\n";
            }
            return "The person hasn't parametrs!!!\n";
        }

        public IEnumerable<Person> GetAll()
        {
            return people;
        }

        private bool isNull() // 
        {
            if (people == null) return true;
            return false;
        }
    }
}
