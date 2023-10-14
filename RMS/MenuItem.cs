namespace RMS
{
    public class MenuItem
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int currency { get; set; }

        public MenuItem(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }

    public class SpecialMenuItem
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public DayOfWeek day_of_week { get; set; }
        public decimal special_price { get; set; }
        public int currency { get; set; }

        public SpecialMenuItem(string name, decimal price, DayOfWeek day_of_week, decimal special_price)
        {
            this.name = name;
            this.price = price;
            this.day_of_week = day_of_week;
            this.special_price = special_price;
        }
    }
}
