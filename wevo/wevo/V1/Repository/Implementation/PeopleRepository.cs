using System;
using System.Collections.Generic;
using System.Linq;
using wevo.Model;
using wevo.Model.Context;

namespace wevo.Repository.Implementation
{
    public class PeopleRepository : IPeopleRepository
    {
        private MySQLContext _context;

        public PeopleRepository(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public void Delete(Person person)
        {
            Person result = _context.People.SingleOrDefault<Person>(p => p.Id.Equals(person.Id));

            try
            {
                if (result != null)
                {
                    _context.People.Remove(result);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Person> FindAll()
        {
            return _context.People.ToList<Person>();
        }

        public Person FindById(long id)
        {
            return _context.People.SingleOrDefault<Person>(p => p.Id.Equals(id));
        }

        public Person Update(Person person)
        {
            Person result = _context.People.SingleOrDefault<Person>(p => p.Id.Equals(person.Id));

            if (result == null) return null;

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return person;
        }
    }
}
