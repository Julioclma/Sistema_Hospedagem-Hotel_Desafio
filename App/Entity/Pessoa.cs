using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.Entity
{
    public class Pessoa
    {
        public string Nome { get; }
        public string Cpf { get; }

        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}