using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.Data
{
    public class SelectorPlantillaDeDatosRobot : DataTemplateSelector
    {
        public DataTemplate robotGrande { get; set; }
        public DataTemplate robotPequeño { get; set; }

        protected override DataTemplate OnSelectTemplate(Object item, BindableObject Container)
        {
            Robot robot = (Robot)item;

            if (robot.Peso > 20)
            {
                return robotGrande;
            }
            else
            {
                return robotPequeño;
            }
        }
    }
}
