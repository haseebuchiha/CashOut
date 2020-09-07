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
    class Cash
    {
        static void Main()
        {
            for(; ; )
            {
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
            }
        }
    }
}