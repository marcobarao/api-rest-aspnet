using System.Collections.Generic;
using wevo.Data.VO;

namespace wevo.Business
{
    public interface IPeopleBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(PersonVO person);
    }
}
