using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;
using SistemaHospedagemHotel.App.Repository;

namespace SistemaHospedagemHotel.App.Service
{
    public class PessoaService
    {
        PessoaRepository PessoaRepository;
        public PessoaService(PessoaRepository pessoaRepository)
        {
            PessoaRepository = pessoaRepository;
        }

        public bool Create(Pessoa pessoa)
        {
            return PessoaRepository.Create(pessoa);
        }

        public List<Pessoa> All()
        {
            return PessoaRepository.All();
        }
    }
}