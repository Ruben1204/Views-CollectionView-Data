using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.Data
{
    public class PlantillaSeleccionEstadoRobot : DataTemplateSelector
    {
        public DataTemplate RobotActivo { get; set; }
        public DataTemplate RobotInActivo { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Robot)item).Nombre.Contains("LogoMaui") ? RobotActivo : RobotInActivo;
        }

    }
}
