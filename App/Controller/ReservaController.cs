using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;
using SistemaHospedagemHotel.App.Service;

namespace SistemaHospedagemHotel.App.Controller
{
    public class ReservaController
    {
        ReservaService ReservaService;
        public ReservaController(ReservaService reservaService)
        {
            ReservaService = reservaService;
        }
        public void Create(string[] cpfs, int idSuite, int diasReservados)
        {
            bool result = ReservaService.Create(cpfs, idSuite, diasReservados);

            if (result)
            {
                Console.WriteLine($"Reserva na suite: {idSuite}, foi gerada com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro ao gerar a reserva!");
            }
        }
        public void All()
        {
            List<Reserva> reservas = ReservaService.All();
            Console.WriteLine($"*Reservas*");
            foreach (Reserva reserva in reservas)
            {
                Console.WriteLine($"Codigo suite reservada: {reserva.Suite.IdSuite} - Hospedes: {reserva.Hospedes.Count()}, dias reservados: {reserva.DiasReservados}, valor total{reserva.ValorTotal()}");
            }
        }
    }
}