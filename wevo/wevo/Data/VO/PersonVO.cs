using System;

namespace wevo.Data.VO
{
    public class PersonVO
    {
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
