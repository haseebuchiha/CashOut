using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashOut
{
    
    abstract class items
    {
        //brand
        //price
        //stock
        public string brand;
        public int price = 0, stock = 0;

        public void brand_name()
        {
            Console.Write("Enter brand name:");
            brand = Convert.ToString(Console.ReadLine());
        }
        //func: that increases stock by the amount increased and returns the new stock amount 
        public void increase_stoct()
        {

            Console.Write("Enter the amount of stock you want to increase: ");
            price = Convert.ToInt32(Console.ReadLine());

            stock = stock + price;
            Console.Write($"Your current stock: {stock}");
            Console.ReadLine();
        }

        //func: that reduces stock by the amount purchased (Remember to check for empty)
        public void decrease_stock()
        {
            if (stock == 0)
            {
                Console.WriteLine("Stock is empty!!");
            }
            else
            {
                Console.Write("Enter the amount of stock you want to increase: ");
                price = Convert.ToInt32(Console.ReadLine());

                stock = stock - price;
                Console.Write($"Your current stock: {stock}");
                Console.ReadLine();
            }


        }
        //Func: return total amount
        public void get_stock()
        {
            Console.WriteLine($"Stock={stock}\n");
            Console.WriteLine($"Stock={price}\n");
            Console.WriteLine($"Brand Name={brand}\n");
        }
    };
    
    
    

    //Cigarette brand
    //Cigarette brand

    //TOOD: Create  Cigarette class that inherits from Items
    class Cigarette : items { };
    //TOOD: Create  Beverage class that inherits from Items
    class Beverage : items { };
    //TOOD: Create Chips class that inherits from Items
    class Chips : items { };
    //TOOD: Create Oil class that inherits from Items
    class Oil : items { };


    //TOOD: Create a Menu class 

    class Cash
    {
        static void Main()
        {
            //Create object of ciggerate
            Cigarette cig = new Cigarette();
            //Create object of Bevrage
            Beverage bev = new Beverage();
            //Create object of Chips
            Chips chips = new Chips();
            //Create object of Oil
            Oil oil = new Oil();
            for(; ; )
            {
                //Buy item: Item type 1 for Cigarette, 2 for Beverage, 3 for CHIPS and 4 for Oil
                int ch;
                Console.WriteLine("          Welcome to Stock Management System");
                Console.WriteLine("         -------------------------------------\n\n");
                Console.WriteLine("Item 1-Cigarette.\n");
                Console.WriteLine("Item 2-Beverage.\n");
                Console.WriteLine("Item 3-Chips.\n");
                Console.WriteLine("Item 4-Oil.\n");
                Console.Write("Enter choice: ");
                ch = int.Parse(Console.ReadLine());


                //Buy item or add to stock for 1
                if (ch == 1)
                {
                    ch = 0;
                    Console.Clear();
                    Console.WriteLine("1-Add to stocks items\n");
                    Console.WriteLine("2-Buy from stock items\n");
                    Console.WriteLine("3-View All Info\n");
                    Console.Write("Enter choice: ");
                    ch = int.Parse(Console.ReadLine());
                    //1-> Brand of cigg, quanitity, total amount
                    if (ch == 1)
                    {
                        ch = 0;
                        Console.Clear();
                        cig.brand_name();
                        Console.Clear();
                        cig.increase_stoct();
                        Console.Clear();
                    }
                    else if(ch == 2)
                    {
                        ch = 0;
                        Console.Clear();
                        cig.decrease_stock();
                        Console.Clear();

                    }
                    //Brand of cigg, quanitity, return new number of stocks
                    else if (ch == 3)
                    {
                        ch = 0;
                        Console.Clear();
                        cig.get_stock();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nInvalid Option Entered!!\n");
                        Console.WriteLine("\nPress any key to return to main menu\n");
                    }
                }
                //add to stock item: 1 for Cigarette, 2 for Beverage, 3 for CHIPS and 4 for Oil
                else if (ch == 2)
                {
                    ch = 0;
                    Console.Clear();
                    Console.WriteLine("1-Add to stocks items\n");
                    Console.WriteLine("2-Buy from stock items\n");
                    Console.WriteLine("3-View All Info\n");
                    Console.Write("Enter choice: ");
                    ch = int.Parse(Console.ReadLine());
                    //2-> Brand of Beverage, quanitity, total amount
                    if (ch == 1)
                    {
                        ch = 0;
                        Console.Clear();
                        bev.brand_name();
                        Console.Clear();
                        bev.increase_stoct();
                        Console.Clear();
                    }
                    else if (ch == 2)
                    {
                        ch = 0;
                        Console.Clear();
                        bev.decrease_stock();
                        Console.Clear();
                    }
                    //Brand of beverage, quanitity, return new number of stocks
                    else if (ch == 3)
                    {
                        ch = 0;
                        Console.Clear();
                        bev.get_stock();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nInvalid Option Entered!!\n");
                        Console.WriteLine("\nPress any key to return to main menu\n");
                    }
                }
                else if(ch == 3)
                {
                    ch = 0;
                    Console.Clear();
                    Console.WriteLine("1-Add to stocks items\n");
                    Console.WriteLine("2-Buy from stock items\n");
                    Console.WriteLine("3-View All Info\n");
                    Console.Write("Enter choice: ");
                    ch = int.Parse(Console.ReadLine());
                    //3-> Brand of Chips, quanitity, total amount
                    if (ch == 1)
                    {
                        ch = 0;
                        Console.Clear();
                        chips.brand_name();
                        Console.Clear();
                        chips.increase_stoct();
                        Console.Clear();
                    }
                    else if (ch == 2)
                    {
                        ch = 0;
                        Console.Clear();
                        chips.decrease_stock();
                        Console.Clear();
                    }
                    //Brand of Chips, quanitity, return new number of stocks
                    else if (ch == 3)
                    {
                        ch = 0;
                        Console.Clear();
                        chips.get_stock();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nInvalid Option Entered!!\n");
                        Console.WriteLine("\nPress any key to return to main menu\n");
                    }
                }
                else if(ch == 4)
                {
                    ch = 0;
                    Console.Clear();
                    Console.WriteLine("1-Add to stocks items\n");
                    Console.WriteLine("2-Buy from stock items\n");
                    Console.WriteLine("3-View All Info\n");
                    Console.Write("Enter choice: ");
                    ch = int.Parse(Console.ReadLine());
                    //3-> Brand of Oil, quanitity, total amount
                    if (ch == 1)
                    {
                        ch = 0;
                        Console.Clear();
                        oil.brand_name();
                        Console.Clear();
                        oil.increase_stoct();
                        Console.Clear();
                    }
                    else if (ch == 2)
                    {
                        ch = 0;
                        Console.Clear();
                        oil.decrease_stock();
                        Console.Clear();
                    }
                    else if (ch == 3)
                    {
                        ch = 0;
                        Console.Clear();
                        oil.get_stock();
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nInvalid Option Entered!!\n");
                        Console.WriteLine("\nPress any key to return to main menu\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid Option Entered!!\n");
                   
                }              
            }
        }


    }
}