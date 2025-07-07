using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;

namespace SistemaHospedagemHotel.App.Repository
{
    public class ReservaRepository
    {

        public List<Reserva> Reservas;
        public ReservaRepository()
        {
            Reservas = new List<Reserva>();
        }
        public bool Create(Reserva reserva)
        {
            Reservas.Add(reserva);
            if (Reservas.Contains(reserva))
            {
                return true;
            }

            return false;
        }
        public List<Reserva> All()
        {
            return Reservas;
        }
    }
}