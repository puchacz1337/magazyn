using System.Xml.Linq;

List<int> ilosc = new List<int>();
List<string> nazwa = new List<string>();
List<double> cena = new List<double>();
int option = 0;
ilosc.Add(10);
nazwa.Add("mleko");
cena.Add(2.5);
ilosc.Add(5);
nazwa.Add("chleb");
cena.Add(2);


while (option != 6)

{
    Console.WriteLine("Wybierz opcję:\r\n\r\n   1. Dodaj produkt\r\n\r\n   2. Usuń produkt\r\n\r\n   3. Wyświetl listę produktów\r\n\r\n   4. Aktualizuj produkt\r\n\r\n   5. Oblicz wartość magazynu\r\n\r\n   6. Wyjście");
     option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine("Podaj nazwę produktu:");
        nazwa.Add(Console.ReadLine());
        Console.WriteLine("Podaj cenę produktu:");
        cena.Add(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Podaj ilość produktu:");
        ilosc.Add(Convert.ToInt32(Console.ReadLine()));
    }
    else if (option == 2)
    {
        Console.WriteLine("Podaj nazwę produktu do usunięcia:");
        string produkt = Console.ReadLine();
        for (int i = 0; i < nazwa.Count; i++)
        {
            if (nazwa[i] == produkt)
            {
                nazwa.RemoveAt(i);
                cena.RemoveAt(i);
                ilosc.RemoveAt(i);
                break;
            }
            else if (i == nazwa.Count - 1)
            {
                Console.WriteLine("Nie ma takiego produktu na liście");
            }
        }
    }
    else if (option == 3)
    {
        Console.WriteLine("Lista produktów:");
        for (int i = 0; i < nazwa.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + nazwa[i] + " - " + cena[i] + "zł - " + ilosc[i] + "szt.");
        }
    }
    else if (option == 4)
    {
        Console.WriteLine("Podaj nazwę produktu który chcesz zmienić:");
        string produkt = Console.ReadLine();
        for (int i = 0; i < nazwa.Count; i++)
        {
            if (nazwa[i] == produkt)
            {
                Console.WriteLine(" 1.nazwa\r\n\r\n 2.cena\r\n\r\n 3.ilość:");
                int zmiana = Convert.ToInt32 (Console.ReadLine());
                if (zmiana == 1)
                {
                    Console.WriteLine("Podaj nową nazwę produktu:");
                    nazwa[i] = Console.ReadLine();
                }
                else if (zmiana == 2)
                {
                    Console.WriteLine("Podaj nową cenę produktu:");
                    cena[i] = Convert.ToDouble(Console.ReadLine());
                }
                else if (zmiana == 3)
                {
                    Console.WriteLine("Podaj nową ilość produktu:");
                    ilosc[i] = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Nie ma takiej opcji.");
                }
                    break;
            }
            else if (i == nazwa.Count - 1)
            {
                Console.WriteLine("Nie ma takiego produktu na liście");
            }
        }
    }
    else if (option == 5)
    {
        double wartość = 0;
        for (int i = 0; i < nazwa.Count; i++)
        {
            wartość += cena[i] * ilosc[i];
        }
        Console.WriteLine("Wartość magazynu wynosi: " + wartość + "zł");
    }
    else if (option == 6)
    {
        
    }

    else
    {
        Console.WriteLine("Nie ma takiej opcji.");
    }
    
}

