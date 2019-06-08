using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wevo.Model
{
    public class Person
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
