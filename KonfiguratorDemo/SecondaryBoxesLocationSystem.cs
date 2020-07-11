using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonfiguratorDemo
{
    static class SecondaryBoxesLocationSystem
    {
        static private readonly Point startLocation = new Point(34, 402);
        static private readonly int deltaX = 157;
        //34 191 348 / 157
        static private int counter = 0;

        static public void SetLocation(Panel panel)
        {
            panel.Location = new Point(startLocation.X + deltaX * counter, startLocation.Y);
            counter++;
        }

        static public void NewModel()
        {
            counter = 0;
        }
    }
}
