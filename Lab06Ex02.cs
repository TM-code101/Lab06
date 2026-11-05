using System.Net;

string heroName = "Pudge";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

while (isRunning)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();



    string? command = Console.ReadLine();

    if (command == "1")
    {
        int damage = strength + weaponDamage;
        Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
    }
    else if (command == "2")
    {
        health += 10;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
    }
    else if (command == "3")
    {
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Nieznana komenda.");
    }
}

void ShowStatus(string name, int health, int maxHealth, int gold)
{
    ShowPanelTitle("status",  ConsoleColor.Blue );
    Console.WriteLine("====================");
    Console.WriteLine($"Bohater: {name}");
    Console.WriteLine($"Zdrowie: {health}/{maxHealth}");
    Console.WriteLine($"Złoto: {gold}");
    Console.WriteLine("====================");
}

void ShowMenu()
{
    ShowPanelTitle("menu", ConsoleColor.Green);
    Console.WriteLine("1. Atak treningowy");
    Console.WriteLine("2. Odpoczynek");
    Console.WriteLine("3. Koniec gry");
    Console.Write("Wybór: ");

}
void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"  {title.ToUpper()}  ");
    Console.ResetColor();
}
