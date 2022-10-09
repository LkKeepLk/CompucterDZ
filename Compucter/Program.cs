using Compucter;

Computer comp1 = new Computer("Кампутер", 16, "Shindoshs", 500);
while (true)
{
    void Menu()
    {
        Console.WriteLine("1 - Включить");
        Console.WriteLine("2 - Установить операционную систему");
        Console.WriteLine("3 - Выключить");
        Console.WriteLine("4 - Получить информацию");
        string h = Console.ReadLine();
        int k = int.Parse(h);
        if (k == 1)
        {
            comp1.TurnOn();
        }
        if (k == 2)
        {
            comp1.InstallOC("MacOC");
        }
        if (k == 3)
        {
            comp1.TurnOff();
        }
        if (k == 4)
        {
            comp1.GetInfo();
        }
    }

    Menu();
}