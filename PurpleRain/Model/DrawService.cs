using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PurpleRain.Model
{
    class DrawService
    {
        public void Draw(List<Drop> rain, Form form)
        {
            Graphics g = form.CreateGraphics();
            g.Clear(Color.Black);
            Pen p = new Pen(Color.MediumPurple, 2.0f);

            for (int i = 0; i < rain.Count; i++)
            {
                g.FillRectangle(Brushes.MediumPurple, rain[i].X, rain[i].Y, 15, 15);
                // g.DrawLine(p, rain[i].X, rain[i].Y, rain[i].X, rain[i].Y + 20);
            }
            g.Dispose();
        }
    }
}
