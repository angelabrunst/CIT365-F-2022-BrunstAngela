using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Brunst
{
    public enum DesktopMaterial
    {
        Laminate = 100, 
        Oak = 200, 
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    internal class Desk
    {
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;

        public string customerName { get; set; }
        public int width {  get; set; }
        public int depth { get; set; }
        public int numOfDrawers { get; set; }
        public DesktopMaterial material { get; set; }
        public int area { get; set; }
    }
}
