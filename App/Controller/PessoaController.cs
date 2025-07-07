using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;
using SistemaHospedagemHotel.App.Service;

namespace SistemaHospedagemHotel.App.Controller
{
    public class PessoaController
    {
        PessoaService PessoaService;
        public PessoaController(PessoaService pessoaService)
        {
            PessoaService = pessoaService;
        }
        public void Create(string nome, string cpf)
        {
            Pessoa pessoa = new Pessoa(nome, cpf);
            bool result = PessoaService.Create(pessoa);

            if (result)
            {
                Console.WriteLine($"Pessoa {nome} e {cpf} Cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro ao cadastrar a pessoa!");
            }
        }
        public void All()
        {
            List<Pessoa> pessoas = PessoaService.All();
            Console.WriteLine($"*Hospedes Cadastrados*");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Nome} - {pessoa.Cpf}");

            }
        }
    }
}