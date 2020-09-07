using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashOut
{

    //TODO: Implement abstract class called items
    //brand
    //price
    //stock
    //func: that reduces stock by the amount purchased (Remember to check for empty)
    //func: that increases stock by the amount increased and returns the new stock amount 
    //Func: return total amount
    //Cigarette brand
    //Cigarette brand

    //TOOD: Create  Cigarette class that inherits from Items
    //TOOD: Create  Beverage class that inherits from Items
    //TOOD: Create Chips class that inherits from Items
    //TOOD: Create Oil class that inherits from Items


    //TOOD: Create a Menu class 
    public abstract class Items
    {
        public string Brand;
        public int Price;
        public int Stock;
        public int StockPurchased;
        public int NewStock;
        //public Items()
       // {
          //  Brand = "Unknown";

       // }
        public Items(string brand, int price, int stock, int stockPurchased, int newStock)
        {
            Brand = brand;
            Price = price;
            Stock = stock;
            StockPurchased = stockPurchased;
            NewStock = newStock;
        }
        public void PurchaseStock(int stock, int stockPurchased)
        {
            if (Stock != 0)
            {
                Stock = Stock - StockPurchased;

            }

        }
        public int Inventory(int stock, int newStock)
        {
            Stock = Stock + NewStock;
            return Stock;
        }
        public int TotalAmount()
        {
            return Stock;
        }
        public void BrandName(string brand)
        {
            Console.WriteLine(Brand);
        }

    }
    public class Cigarette : Items
    {

    }
    public class Beverage : Items
    {

    }
    public class Chips : Items
    {

    }
    public class Oil : Items
    {

    } 
    class Cash
    {
        static void Main()
        {
            // for(; ; )
            //  {
            //TODO: Create a menu that has the following:
            //Buy item or add to stock for 1 
            //Buy item: Item type 1 for Cigarette, 2 for Beverage, 3 for CHIPS and 4 for Oil
            //Create object of ciggerate
            //1-> Brand of cigg, quanitity, total amount
            //Create object of Bevrage
            //2-> Brand of Beverage, quanitity, total amount
            //Create object of Chips
            //3-> Brand of Chips, quanitity, total amount
            //Create object of Oil
            //3-> Brand of Oil, quanitity, total amount
            //add to stock item: 1 for Cigarette, 2 for Beverage, 3 for CHIPS and 4 for Oil
            //Brand of cigg, quanitity, return new number of stocks
            //Brand of beverage, quanitity, return new number of stocks
            //Brand of Chips, quanitity, return new number of stocks
            // }
            while (true)
            {
                Console.WriteLine("Enter 1 for Cigarette, 2 for Beverage, 3 for Chips, 4 for Oil, 5 to finish the program: ");
                string UserInput = Console.ReadLine();
                if (UserInput == "1")
                {
                    Cigarette cig = new Cigarette();
                    Console.WriteLine("Brand: \n");
                    cig.BrandName("Cig1");
                    //cig.PurchaseStock(500, 55);
                    Console.WriteLine("Stocks purchased: \n");
                    cig.PurchaseStock(500, 55);
                    Console.WriteLine("Stock increased: ");
                    cig.Inventory(500, 55);
                    Console.WriteLine("Total: ");
                    cig.TotalAmount();



                }
                else if (UserInput == "2")
                {
                    Beverage bev = new Beverage();
                    Console.WriteLine("Brand: \n");
                    bev.BrandName("Cola1");
                    Console.WriteLine("Stocks purchased: \n");
                    bev.PurchaseStock(1000, 100);
                    Console.WriteLine("Stock increased: ");
                    bev.Inventory(1000, 150);
                    Console.WriteLine("Total: ");
                    bev.TotalAmount();






                }
                else if (UserInput == "3")
                {
                    Chips chip = new Chips();
                    Console.WriteLine("Brand: \n");
                    chip.BrandName("Chips1");
                    Console.WriteLine("Stocks purchased: \n");
                    chip.PurchaseStock(400, 47);
                    Console.WriteLine("Stock increased: ");
                    chip.Inventory(400, 66);
                    Console.WriteLine("Total: ");
                    chip.TotalAmount();



                }
                else if (UserInput == "4")
                {
                    Oil oilObj = new Oil();
                    Console.WriteLine("Brand: \n");
                    oilObj.BrandName("Oil 1");
                    Console.WriteLine("Stocks purchased: \n");
                    oilObj.PurchaseStock(366, 30);
                    Console.WriteLine("Stock increased: ");
                    oilObj.Inventory(366, 66);
                    Console.WriteLine("Total: ");
                    oilObj.TotalAmount();


                } 
                else if (UserInput == "5")
                {
                    Console.WriteLine("Thanks! ");
                    break;
                }
            }
    }
}