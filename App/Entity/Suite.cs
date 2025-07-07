using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.Entity
{
    public class Suite

    {
        public int IdSuite { get; }
        public int Capacidade { get; }
        public double ValorDiaria { get; }

        public Suite(int idSuite, int capacidade, double valorDiaria)
        {
            IdSuite = idSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}