using System.Collections.Generic;
using wevo.Data.Converters;
using wevo.Data.VO;
using wevo.Model;
using wevo.Repository;

namespace wevo.Business.Implementation
{
    public class PeopleBusiness : IPeopleBusiness
    {
        private IPeopleRepository _repository;
        private readonly PeopleConverter _converter;

        public PeopleBusiness(IPeopleRepository repository)
        {
            _repository = repository;
            _converter = new PeopleConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            Person personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(PersonVO person)
        {
            Person personEntity = _converter.Parse(person);
            _repository.Delete(personEntity);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public PersonVO Update(PersonVO person)
        {
            Person personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
