using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.App.View.SubMenu
{
    public class SubMenuImplement
    {
        public SubMenuImplement(SubMenuInterface subMenuInterface)
        {
            subMenuInterface.Submenu();
        }
    }
}