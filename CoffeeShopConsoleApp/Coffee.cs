using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffee orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            return 20-Discount;
        }

        public abstract string Strength();

        public int Discount { get; set; }
    }

    public class BlackCoffee : Coffee
    {
        public override string Strength()
        {
            return "Strong";
        }
    }

    public class Latte : Coffee, IMilk
    {
        public override int price()
        {
            return 40-Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }

    public class Cortado : Coffee, IMilk
    {
        public override int price()
        {
            return 25-Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }

        public int mlMilk()
        {
            return 40;
        }
    }

    internal interface IMilk
    {
        int mlMilk();
    }
}
