using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;
using SistemaHospedagemHotel.App.Repository;

namespace SistemaHospedagemHotel.App.Service
{
    public class ReservaService
    {
        ReservaRepository ReservaRepository;
        PessoaService PessoaService;
        SuiteService SuiteService;

        public ReservaService(ReservaRepository reservaRepository, PessoaService pessoaService, SuiteService suiteService)
        {
            ReservaRepository = reservaRepository;
            PessoaService = pessoaService;
            SuiteService = suiteService;
        }

        public bool Create(string[] cpfs, int idSuite, int diasReservados)
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            foreach (string cpf in cpfs)
            {
                pessoas.Add(PessoaService.FindByCpf(cpf));
            }

            Suite suite = SuiteService.FindBySuiteId(idSuite);

            try
            {
                Reserva reserva = new Reserva(pessoas, suite, diasReservados);
                return ReservaRepository.Create(reserva);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                return false;
            }

        }

        public List<Reserva> All()
        {
            return ReservaRepository.All();
        }
    }
}