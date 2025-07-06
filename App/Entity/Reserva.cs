using System;
using System.Collections.Generic;
using System.Linq;
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
        }

    }
}