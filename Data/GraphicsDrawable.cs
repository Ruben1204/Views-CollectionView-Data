using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.Data
{
    public class GraphicsDrawable : IDrawable
    {
        public Color LineColor { get; set; } = Colors.Red;
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            //Configuramos y dibujamos la linea
            canvas.StrokeColor = LineColor;
            canvas.StrokeSize = 4;
            canvas.StrokeDashPattern = new float[] { 2, 2 };
            canvas.DrawLine(0, 0, 100, 100);

            // calcular el centro del lienzo
            var centerX = dirtyRect.Center.X;
            var centerY = dirtyRect.Center.Y;

            // ajustar los puntos finales de la línea para que estén en el centro del lienzo
            var startX = centerX - 100; // 100 es la mitad del ancho de la línea
            var startY = centerY - 100; // 100 es la mitad de la altura de la línea
            var endX = centerX + 100;
            var endY = centerY + 100;

            // dibujar la línea
            canvas.DrawLine(startX, startY, endX, endY);
        }



    }
}
