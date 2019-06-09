using System;
using System.Collections.Generic;
using Tapioca.HATEOAS;

namespace wevo.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
