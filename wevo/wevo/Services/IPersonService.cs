using System.Collections.Generic;
using wevo.Model;

namespace wevo.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(Person person);
    }
}
