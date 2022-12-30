using System;


public class LiskovSubstititution
{
    public class MenuItem
    {
        public string Name;
        public string Description { get; set; } 
        public double price { get; set; }

		public MenuItem(double price, string Description, string Name)
		{
            this.Name = Name;
            this.price = price;
            this.Description = Description;
		}
        public double getPrice()
        {
            return this.price;
        }
    };

    public class BeverageItems : MenuItem
    {
		public BeverageItems(double price, string Description, string Name) : base(price, Description, Name)
		{
          
		}
        public double getPriceWithDiscount(int discountPercentage)
        {
            return this.price - (discountPercentage * 0.1 * this.price);
        }
    }

    public static void printItemPrice(MenuItem item)
    {
        // below is the voilation
        if (item is BeverageItems)
        {
            Console.WriteLine(((BeverageItems)item).getPriceWithDiscount(10));
        }
        else
        {
            Console.WriteLine(item.getPrice());
        }
    }

    public static void main(string[] args)
    {
        MenuItem item = new MenuItem(23.9, "ham burger is the burger", "Burger");
        BeverageItems bItem = new BeverageItems(29.9, "Souping around", "Soup");

        printItemPrice(item);
        printItemPrice(bItem);
    }
}
