using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.Entity
{
    public class Reserva
    {
        public List<Pessoa> Hospedes;
        public Suite Suite;
        public int DiasReservados;


        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
            ValidaReserva(hospedes, suite);
        }

        private void ValidaReserva(List<Pessoa> hospedes, Suite suite)
        {
            if (hospedes.Count() > suite.Capacidade)
            {
                throw new Exception($"Capacidade de {suite.Capacidade} não suportada para alocação com {hospedes.Count()} hospedes!");
            }
        }

        public double ValorTotal()
        {
            return DiasReservados * Suite.ValorDiaria;
        }

    }
}