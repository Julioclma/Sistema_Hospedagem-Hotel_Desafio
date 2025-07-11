using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;

namespace SistemaHospedagemHotel.App.Repository
{
    public class PessoaRepository
    {
        public List<Pessoa> Pessoas;
        public PessoaRepository()
        {
            Pessoas = new List<Pessoa>();
        }
        public bool Create(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
            if (Pessoas.Contains(pessoa))
            {
                return true;
            }

            return false;
        }
        public List<Pessoa> All()
        {
            return Pessoas;
        }
        public Pessoa FindByCpf(string cpf)
        {
            try
            {
                Pessoa pessoa = Pessoas.Find(pessoa => pessoa.Cpf == cpf);
                return pessoa;
            }
            catch (System.Exception)
            {
                throw new Exception("Pessoa não encontrada");
            }
        }
    }
}