namespace RMS
{
    public abstract class BaseMenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Currency { get; set; }
        public int Quantity { get; set; }

        public BaseMenuItem(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = 1;
        }
    }

    public class MenuItem : BaseMenuItem, IMenu
    {
        public MenuItem(string name, decimal price): base(name, price)
        {
        }

        public decimal GetCalculatedPrice()
        {
            return Quantity * Price.ToConvertedCurrency(Currency);
        }
    }

    public class SpecialMenuItem : BaseMenuItem, IMenu
    {
        public DayOfWeek DayOfWeek { get; set; }
        public decimal SpecialPrice { get; set; }

        public SpecialMenuItem(string name, decimal price, DayOfWeek dayOfWeek, decimal specialPrice): base(name, price)
        {
            this.DayOfWeek = dayOfWeek;
            this.SpecialPrice = specialPrice;
        }

        public decimal GetCalculatedPrice()
        {
            if (DayOfWeek == DateTime.Today.DayOfWeek)
            {
                return Quantity * SpecialPrice.ToConvertedCurrency(Currency);
            }
            return Quantity * Price.ToConvertedCurrency(Currency);
        }
    }
}
