List<Product> inventory = new List<Product>();
bool exit = false;
while (!exit)
{
    Console.WriteLine("\nWybierz opcję:");
    Console.WriteLine("1. dodaj produkt");
    Console.WriteLine("2. usun produkt");
    Console.WriteLine("3.wyswietl liste produktow");
    Console.WriteLine("4.aktualizuj produkt");
    Console.WriteLine("5. oblicz wartosc magazynu");
    Console.WriteLine("6. wyjscie");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            AddProduct(inventory);
            break;
        case "2":
            RemoveProduct(inventory);
            break;
        case "3":
            DisplayProducts(inventory);
            break;
        case "4":
            UpdateProduct(inventory);
            break;
        case "5":
            CalculateInventoryValue(inventory);
            break;
        case "6":
            exit = true;
            break;


    }
    static void AddProduct(List<Product> inventory)
    {
        Console.Write("Podaj nazwe produktu:");
        string name = Console.ReadLine();

        Console.Write("podaj ilosc:");
        int quantity = Convert.ToInt32(Console.ReadLine());


        Console.Write("Podaj cenę: ");
        string input = Console.ReadLine();

        double price;
        if (double.TryParse(input, out price))
        {
            Console.WriteLine($"Cena: {price}");
        }

        inventory.Add(new Product { Name = name, Quantity = quantity, UnitPrice = price });
        Console.WriteLine("Produkt dodany!");
    }
    static void RemoveProduct(List<Product> inventory)
    {
        Console.Write("Podaj nazwe produktu:");
        string name = Console.ReadLine();

        Product productToRemove = inventory.Find(p => p.Name == name);
        if (productToRemove != null)
        {
            inventory.Remove(productToRemove);
            Console.WriteLine("Produkt usunięty!");
        }
        else
        {
            Console.WriteLine("Nie ma takiego produktu");
        }
    }
    static void DisplayProducts(List<Product> inventory)
    {
        Console.WriteLine("\nLista produktów:");
        foreach (var product in inventory)
        {
            Console.WriteLine($"Nazwa: {product.Name}, Ilość: {product.Quantity}, Cena: {product.UnitPrice:C}");
        }
    }
    static void UpdateProduct(List<Product> inventory)
    {
        Console.Write("Podaj nazwę produktu ");
        string name = Console.ReadLine();

        Product productToUpdate = inventory.Find(p => p.Name == name);
        if (productToUpdate != null)
        {
            Console.WriteLine("Co chcesz zaktualizować?");
            Console.WriteLine("1. Ilość");
            Console.WriteLine("2. Cenę");
            Console.WriteLine("3. Oba");

            string option = Console.ReadLine();
            if (option == "1" || option == "3")
            {
                Console.Write("Podaj nową ilość: ");
                productToUpdate.Quantity = Convert.ToInt32(Console.ReadLine());
            }
            if (option == "2" || option == "3")
            {
                Console.Write("Podaj nową cenę: ");
                productToUpdate.UnitPrice = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("zaktualizowane");
        }
        else
        {
            Console.WriteLine("nie ma takiego produktu");
        }
    }
    static void CalculateInventoryValue(List<Product> inventory)
    {
        double totalValue = 0;
        foreach (var product in inventory)
        {
            totalValue += product.Quantity * product.UnitPrice;
        }
        Console.WriteLine($"Całkowita wartość magazynu: {totalValue:C}");
    }
}
