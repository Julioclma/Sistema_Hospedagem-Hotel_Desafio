using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.Entity
{
    public class Suite

    {
        public string IdSuite { get; }
        public string Capacidade { get; }
        public string ValorDiaria { get; }

        public Suite(string idSuite, string capacidade, string valorDiaria)
        {
            IdSuite = idSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}