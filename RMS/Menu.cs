namespace RMS
{
    public class Menu
    {
        public List<IMenu> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<IMenu>();
        }

        public decimal CalculateTotalPrice()
        {
            return MenuItems.Sum(x => x.GetCalculatedPrice());
        }
    }
}
