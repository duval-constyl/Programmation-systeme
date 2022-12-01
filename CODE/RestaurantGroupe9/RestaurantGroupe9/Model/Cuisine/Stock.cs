using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class Stock
    {
        private List<string> ingredients = new List<string>();

        public Stock()
        {
            ingredients.Add("cube");
            ingredients.Add("sel");
            ingredients.Add("oignon");
            ingredients.Add("persil");
            ingredients.Add("rondel");
            ingredients.Add("piment");
            ingredients.Add("pepper");
        }

    }
}
