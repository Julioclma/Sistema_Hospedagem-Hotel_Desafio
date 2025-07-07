using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaHospedagemHotel.App.Controller;
using SistemaHospedagemHotel.App.Service;

namespace SistemaHospedagemHotel.App.View.SubMenu
{
    public class Pessoa : SubMenuInterface
    {
        public bool ExibeSubmenu = true;
        public PessoaController PessoaController;
        public Pessoa(PessoaController pessoaController)
        {
            PessoaController = pessoaController;
        }
        public void Submenu()
        {

            while (ExibeSubmenu)
            {
                Console.WriteLine($"*Menu Hospedes*");
                Console.WriteLine($"1 - Cadastrar Pessoa\n2 - Listar Pessoas\n0 - Voltar ao Menu Principal");
                int selected = Convert.ToInt32(Console.ReadLine());

                switch (selected)
                {
                    case 1:
                        Console.WriteLine("Insira o nome da pessoa:");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Insira o cpf da pessoa:");
                        string cpf = Console.ReadLine();

                        PessoaController.Create(nome, cpf);
                        break;
                    case 2:
                        PessoaController.All();
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