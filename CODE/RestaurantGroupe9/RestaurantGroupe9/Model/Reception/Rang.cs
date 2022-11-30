
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Reception
{
    class Rang
    {
        public List<Table> tables;

        public Rang(int rang)

        {
            tables = new List<Table>();


            switch (rang)

            {
                case 1:
                    tables.Add(new Table(358, 56, 8, 1));
                    tables.Add(new Table(515, 56, 8, 2));
                    tables.Add(new Table(325, 192, 8, 3));
                    tables.Add(new Table(496, 177, 8, 4));
                    break;

                case 2:
                    tables.Add(new Table(192, 230, 5, 5));
                    tables.Add(new Table(252, 336, 5, 6));
                    tables.Add(new Table(397, 336, 5, 7));
                    tables.Add(new Table(537, 336, 5, 8));
                    break;

                default:
                    break;
            }
        }
    }
}
