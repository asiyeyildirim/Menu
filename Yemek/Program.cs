using System;

namespace Yemek
{
   internal class Program
    {
        static void Main(string[] args)
        {

            //object identification Category

            clsCategory clscategory = new clsCategory();

            clscategory.CatId = 1;
            clscategory.CatName = "Çorbalar";

            Console.WriteLine("Kategori Listesi");
            Console.WriteLine("========================="+"\n\n");
            Console.WriteLine(clscategory.CatId +"\t"+ clscategory.CatName);


            //object identification Menu
            clsMenuList clsMenu = new clsMenuList();
            clsMenu.MenuId = 1;
            clsMenu.MenuName = "Deniz Restaurant Menü";
            clsMenu.FoodName = "Mercimek Çorbası";
            clsMenu.FoodPrice = 40;
            clsMenu.CatId = 1;

            Console.WriteLine(clsMenu.MenuName +" Yemek Listesi");
            Console.WriteLine("==========================" + "\n\n");
            Console.WriteLine(clsMenu.MenuId + "\t" + clsMenu.FoodName+"\t"+clsMenu.FoodPrice);



            Console.ReadKey();
        }
    }
}
