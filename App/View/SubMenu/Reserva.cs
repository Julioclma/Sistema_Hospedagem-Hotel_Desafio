using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.View.SubMenu
{
    public class Reserva : SubMenuInterface
    {
        public bool ExibeSubmenu = true;
        public void Submenu()
        {

            while (ExibeSubmenu)
            {
                Console.WriteLine($"*Menu Reservas*");
                Console.WriteLine($"1 - Cadastrar Reserva\n2 - Listar Reserva");
                int selected = Convert.ToInt32(Console.ReadLine());

                switch (selected)
                {
                    case 1:
                        Console.WriteLine($"Cadastrando Reserva.");
                        break;
                    case 2:
                        Console.WriteLine($"Listando Reservas.");
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