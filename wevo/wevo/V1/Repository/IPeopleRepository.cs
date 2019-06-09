using System.Collections.Generic;
using wevo.Model;

namespace wevo.Repository
{
    public interface IPeopleRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll(string query);
        Person Update(Person person);
        void Delete(Person person);
        int GetCount();
    }
}
