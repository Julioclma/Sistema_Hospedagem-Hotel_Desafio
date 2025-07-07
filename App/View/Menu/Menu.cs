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

        public Menu()
        {
            InjectionDependencies();
            Application();
        }

        private void InjectionDependencies()
        {
            PessoaController = new PessoaController(new PessoaService(new PessoaRepository()));
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
                        new SubMenuImplement(new Suite());
                        break;

                    case 3:
                        new SubMenuImplement(new Reserva());
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