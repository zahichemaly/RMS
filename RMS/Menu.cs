namespace RMS
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public List<SpecialMenuItem> specialItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>();
            specialItems = new List<SpecialMenuItem>();
        }

        public decimal CalculateTotalPrice(List<MenuItem> order)
        {
            decimal total = 0;
            foreach (var xyz in order)
            {
                var p = xyz.price;
                if (xyz.currency == 1)
                {
                    p = p * 1.1m;
                }
                total += p;
            }
            return total;
        }

        public decimal CalculateTotalPrice(List<SpecialMenuItem> specialOrder)
        {
            decimal total = 0;
            foreach (var a in specialOrder)
            {
                if (a.day_of_week == DateTime.Today.DayOfWeek)
                {
                    var p = a.special_price;
                    if (a.currency == 1)
                    {
                        p = p * 1.1m;
                    }
                    total += p;
                }
                else
                {
                    var p = a.price;
                    if (a.currency == 1)
                    {
                        p = p * 1.1m;
                    }
                    total += p;
                }
            }
            return total;
        }
    }
}
