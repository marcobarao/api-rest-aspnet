using System;
using System.Collections.Generic;
using wevo.Models;

namespace wevo.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(Person person)
        {
        
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        public Person FindById(long id)
        {
            return new Person {
                Id = 1,
                Nome = "Marco Antônio Barão Neves",
                Email = "marco.barao@outlook.com",
                Telefone = "11 97070-7070",
                Sexo = 'M',
                DataNascimento = new DateTime(2000, 5, 16)
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = i,
                Nome = "Person Name " + i,
                Email = i + "person@person.com",
                Telefone = "11 97070-707" + i,
                Sexo = 'M',
                DataNascimento = new DateTime(2000, 5, i)
            };
        }
    }
}
