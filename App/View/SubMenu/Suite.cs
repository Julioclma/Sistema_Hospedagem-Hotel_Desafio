using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Controller;

namespace SistemaHospedagemHotel.App.View.SubMenu
{
    public class Suite : SubMenuInterface
    {
        public bool ExibeSubmenu = true;
        public SuiteController SuiteController;
        public Suite(SuiteController suiteController)
        {
            SuiteController = suiteController;
        }
        public void Submenu()
        {

            while (ExibeSubmenu)
            {
                Console.WriteLine($"*Menu Suite*");
                Console.WriteLine($"1 - Cadastrar Suite\n2 - Listar Suites(Disponiveis)\n0 - Voltar ao Menu Principal");
                int selected = Convert.ToInt32(Console.ReadLine());

                switch (selected)
                {
                    case 1:
                        Console.WriteLine("Insira o id da suite:");
                        int idSuite = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Insira a capacidade:");
                        int capacidade = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Insira o valor da diária:");
                        double valorDiaria = Convert.ToDouble(Console.ReadLine());

                        SuiteController.Create(idSuite, capacidade, valorDiaria);
                        break;
                    case 2:
                        SuiteController.All();
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