using RMS;

Menu menu = new Menu();

MenuItem menuItem = new MenuItem("Burger", 10.0m);
MenuItem menuItem2 = new MenuItem("French Fries", 2.0m);
menuItem2.Currency = 1;
menu.MenuItems.Add(menuItem);
menu.MenuItems.Add(menuItem);
menu.MenuItems.Add(menuItem2);

SpecialMenuItem specialMenuItem = new SpecialMenuItem("Pizza", 12.0m, DayOfWeek.Wednesday, 8.0m);
menu.MenuItems.Add(specialMenuItem);

var totalBill = menu.CalculateTotalPrice();

Console.WriteLine("Total Price: " + totalBill);
