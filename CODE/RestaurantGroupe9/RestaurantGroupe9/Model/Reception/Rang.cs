
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
                    tables.Add(new Table(92, 316, 4, 1));
                    tables.Add(new Table(220, 316, 4, 2));
                    tables.Add(new Table(348, 316, 4, 3));
                    tables.Add(new Table(476, 316, 4, 4));

                    tables.Add(new Table(92, 376, 6, 5));
                    tables.Add(new Table(220, 376, 6, 6));
                    tables.Add(new Table(348, 376, 6, 7));
                    tables.Add(new Table(444, 408, 2, 8));
                    tables.Add(new Table(508, 408, 2, 9));
                    break;
                case 2:
                    tables.Add(new Table(188, 536, 8, 10));
                    tables.Add(new Table(284, 504, 8, 11));
                    tables.Add(new Table(412, 504, 6, 12));
                    tables.Add(new Table(510, 536, 2, 13));

                    tables.Add(new Table(156, 662, 10, 14));
                    tables.Add(new Table(284, 662, 2, 15));
                    tables.Add(new Table(412, 630, 2, 16));
                    tables.Add(new Table(510, 630, 2, 17));

                    break;
                default:
                    break;
            }
        }
    }
}
