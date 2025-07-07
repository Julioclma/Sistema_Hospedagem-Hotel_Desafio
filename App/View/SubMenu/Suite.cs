using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.View.SubMenu
{
    public class Suite : SubMenuInterface
    {
        public bool ExibeSubmenu = true;
        public void Submenu()
        {

            while (ExibeSubmenu)
            {
                Console.WriteLine($"*Menu Suite*");
                Console.WriteLine($"1 - Cadastrar Suite\n2 - Listar Suites(Disponiveis)");
                int selected = Convert.ToInt32(Console.ReadLine());

                switch (selected)
                {
                    case 1:
                        Console.WriteLine($"Cadastrando Suite.");
                        break;
                    case 2:
                        Console.WriteLine($"Listando Suites.");
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