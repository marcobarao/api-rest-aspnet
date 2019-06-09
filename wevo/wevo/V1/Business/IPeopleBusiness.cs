using System.Collections.Generic;
using Tapioca.HATEOAS.Utils;
using wevo.Data.VO;
using wevo.Model;

namespace wevo.Business
{
    public interface IPeopleBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        PagedSearchDTO<PersonVO> FindAll(string sortDirection, int pageSize, int page);
        PersonVO Update(PersonVO person);
        void Delete(PersonVO person);
    }
}
