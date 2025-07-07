using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Entity;
using SistemaHospedagemHotel.App.Service;

namespace SistemaHospedagemHotel.App.Controller
{
    public class SuiteController
    {
        SuiteService SuiteService;
        public SuiteController(SuiteService suiteService)
        {
            SuiteService = suiteService;
        }
        public void Create(int idSuite, int capacidade, double valorDiaria)
        {
            Suite Suite = new Suite(idSuite, capacidade, valorDiaria);
            bool result = SuiteService.Create(Suite);

            if (result)
            {
                Console.WriteLine($"Suite {idSuite}Cadastrada com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro ao cadastrar a Suite!");
            }
        }
        public void All()
        {
            List<Suite> Suites = SuiteService.All();
            Console.WriteLine($"*Suites Cadastradas*");
            foreach (Suite Suite in Suites)
            {
                Console.WriteLine($"Código: {Suite.IdSuite} - capacidade: {Suite.Capacidade} - valor diária: {Suite.ValorDiaria}");

            }
        }
    }
}