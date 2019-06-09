using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wevo.Data.Converter;
using wevo.Data.VO;
using wevo.Model;

namespace wevo.Data.Converters
{
    public class PeopleConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return new Person();

            return new Person
            {
                Id = origin.Id,
                Nome = origin.Nome,
                CPF = origin.CPF,
                Email = origin.Email,
                Telefone = origin.Telefone,
                Sexo = origin.Sexo,
                DataNascimento = origin.DataNascimento
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return new PersonVO();

            return new PersonVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
                CPF = origin.CPF,
                Email = origin.Email,
                Telefone = origin.Telefone,
                Sexo = origin.Sexo,
                DataNascimento = origin.DataNascimento
            };
        }

        public List<Person> ParseList(List<PersonVO> origin)
        {
            if (origin == null) return new List<Person>();

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> ParseList(List<Person> origin)
        {
            if (origin == null) return new List<PersonVO>();

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
