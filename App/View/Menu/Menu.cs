using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Controller;
using SistemaHospedagemHotel.App.Repository;
using SistemaHospedagemHotel.App.Service;
using SistemaHospedagemHotel.App.View.SubMenu;

namespace SistemaHospedagemHotel.App.View.Menu
{
    public class Menu
    {
        public bool ExibeMenu = true;
        public PessoaController PessoaController;
        public SuiteController SuiteController;
        public ReservaController ReservaController;

        public Menu()
        {
            InjectionDependencies();
            Application();
        }

        private void InjectionDependencies()
        {
            SuiteRepository suiteRepository = new SuiteRepository();
            PessoaRepository pessoaRepository = new PessoaRepository();

            PessoaController = new PessoaController(new PessoaService(pessoaRepository));
            SuiteController = new SuiteController(new SuiteService(suiteRepository));
            ReservaController = new ReservaController(
                new ReservaService
                    (
                        new ReservaRepository(),
                        new PessoaService(pessoaRepository),
                        new SuiteService(suiteRepository)
                    )
                );
        }


        private void Application()
        {
            Console.WriteLine($"*Bem vindo ao sistema de Hospedagem de Hotel*");


            while (ExibeMenu)
            {
                Console.Clear();
                Options();
                int selected = Convert.ToInt32(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        new SubMenuImplement(new Pessoa(PessoaController));
                        break;

                    case 2:
                        new SubMenuImplement(new Suite(SuiteController));
                        break;

                    case 3:
                        new SubMenuImplement(new Reserva(ReservaController));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"{selected} Opção inválida!");
                        break;

                }

            }
        }
        private void Options()
        {
            Console.WriteLine($"Escolha a opção desejada:");
            Console.WriteLine($"1 - Hospede");
            Console.WriteLine($"2 - Suite");
            Console.WriteLine($"3 - Reservar");
            Console.WriteLine($"0 - Fechar Sistema");

        }
    }
}