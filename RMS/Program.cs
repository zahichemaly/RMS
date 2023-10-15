using RMS;

Menu menu = new Menu();

MenuItem menuItem = new MenuItem("Burger", 10.0m);
MenuItem menuItem2 = new MenuItem("French Fries", 2.0m);
menuItem2.currency = 1;
menu.MenuItems.Add(menuItem);
menu.MenuItems.Add(menuItem);
menu.MenuItems.Add(menuItem2);

SpecialMenuItem specialMenuItem = new SpecialMenuItem("Pizza", 16.0m, DateTime.Now.DayOfWeek, 12.0m);
menu.specialItems.Add(specialMenuItem);

// 2 bugers, 1 french fries
List<MenuItem> o = new List<MenuItem>()
{
    menuItem,
    menuItem,
    menuItem2
};

List<SpecialMenuItem> so = new List<SpecialMenuItem>()
{
    specialMenuItem
};


decimal total1 = menu.CalculateTotalPrice(o);
decimal total2 = menu.CalculateTotalPrice(so);
decimal totalfinal = total1 + total2;

Console.WriteLine("Total Price: " + totalfinal);
