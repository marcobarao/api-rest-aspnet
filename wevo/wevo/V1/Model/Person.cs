﻿using System;
using System.ComponentModel.DataAnnotations;

namespace wevo.Model
{
    public class Person
    {
        [Key]
        public long? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
