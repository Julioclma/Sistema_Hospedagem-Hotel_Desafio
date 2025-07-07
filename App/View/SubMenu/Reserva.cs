using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Controller;

namespace SistemaHospedagemHotel.App.View.SubMenu
{
    public class Reserva : SubMenuInterface
    {
        public bool ExibeSubmenu = true;

        public ReservaController ReservaController;
        public Reserva(ReservaController reservaController)
        {
            ReservaController = reservaController;
        }
        public void Submenu()
        {

            while (ExibeSubmenu)
            {
                Console.WriteLine($"*Menu Reservas*");
                Console.WriteLine($"1 - Cadastrar Reserva\n2 - Listar Reserva\n0 - Voltar ao Menu Principal");
                int selected = Convert.ToInt32(Console.ReadLine());

                switch (selected)
                {
                    case 1:

                        Console.WriteLine($"Qual a quantidade de hospedes?");
                        int quantidade = Convert.ToInt32(Console.ReadLine());
                        string[] cpfs = new string[quantidade];

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.WriteLine($"Insira o cpf da pessoa nª {i + 1}:");
                            cpfs[i] = Console.ReadLine();
                        }


                        Console.WriteLine("Insira o id da Suite:");
                        int idSuite = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Insira a quantidade de dias reservados:");
                        int quantidadeDias = Convert.ToInt32(Console.ReadLine());

                        ReservaController.Create(cpfs, idSuite, quantidadeDias);
                        break;
                    case 2:
                        ReservaController.All();
                        break;
                    case 0:
                        ExibeSubmenu = false;
                        break;
                    default:
                        Console.WriteLine($"{selected} Opção inválida!");
                        break;

                }
            }
        }
    }
}