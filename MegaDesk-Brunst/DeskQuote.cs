using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Brunst
{
    class DeskQuote
    {
        #region quote variables
        public string customerName { get; set; }
        public DateTime quoteDate { get; set; }
        public Desk Desk = new Desk();
        public int rushDays { get; set; }
        public int quoteAmount;
        #endregion

        #region constants
        private const int BASE_COST = 200;
        private const int SIZE_LIMIT = 1000;
        private const int COST_PER_DRAWER = 50;
        private const int COST_PER_AREA = 1;
        #endregion


        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int numOfDrawers, Desk.DesktopMaterial material, int rushDays)
        {
            customerName = customerName;
            quoteDate = quoteDate;
            Desk.width = width;
            Desk.depth = depth;
            Desk.numOfDrawers = numOfDrawers;
            Desk.material = material;
            rushDays = rushDays;

            Desk.area = Desk.width * Desk.depth;
        }

        public int CalcQuote()
        {
            return quoteAmount = BASE_COST + AreaCost() + DrawerCost() + (int)Desk.material + RushCost();
        }

        private int AreaCost()
        {
            if (Desk.area > SIZE_LIMIT)
            {
                return (Desk.area - SIZE_LIMIT) * COST_PER_AREA;
            }
            else
            {
                return 0;
            }
        }

        private int DrawerCost()
        {
            int DrawerCost = Desk.numOfDrawers * COST_PER_DRAWER;
            return DrawerCost;
        }

        private int RushCost()
        {
            int rushCost = 0;
            if(rushDays.Equals(3))
            {
                if (Desk.area < 1000)
                {
                    rushCost = 60;
                }
                else if (Desk.area > 1000 && Desk.area < 2000)
                {
                    rushCost = 70;
                }
                else
                {
                    rushCost = 80;
                }
            }
            else if (rushDays.Equals(5))
            {
                if (Desk.area < 1000)
                {
                    rushCost = 40;
                }
                else if (Desk.area > 1000 && Desk.area < 2000)
                {
                    rushCost = 50;
                }
                else
                {
                    rushCost = 60;
                }
            }
            else if (rushDays.Equals(7))
            {
                if (Desk.area < 1000)
                {
                    rushCost = 30;
                }
                else if (Desk.area > 1000 && Desk.area < 2000)
                {
                    rushCost = 35;
                }
                else
                {
                    rushCost = 40;
                }
            }
            else
            {
                rushCost = 0;
            }
            return rushCost;
        }
    }
}
