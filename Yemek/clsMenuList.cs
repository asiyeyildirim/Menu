using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek
{
    internal class clsMenuList
    {

        public clsMenuList()
        {

        }

        public int MenuId { get; set; } //list line number
        public string MenuName { get; set; } 
        public string FoodName { get; set; } 
        public int FoodPrice { get; set; } 
        public int CatId { get; set; } 
    



    }
}
