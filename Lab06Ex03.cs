string heroName = "Pudge";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

while (isRunning && IsGameOver(health) == false)
{
    ShowStatus(heroName, health, maxHealth, gold);
    ShowMenu();



    string? command = Console.ReadLine();

    if (command == "1")
    {
        int damage = CalculateDamage(strength, weaponDamage);
        
    }
    else if (command == "2")
    {
        health = Heal(health, 10, maxHealth);
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


int CalculateDamage(int strength, int weaponDamage)
{
     int totalDamage = weaponDamage + strength;
    Console.WriteLine($"Zadajesz {totalDamage} obrażeń manekinowi.");
    return totalDamage;
}
int Heal(int health, int amount, int maxHealth)
{
    int healing = health + amount;
    if(healing > maxHealth){
        healing = maxHealth;
        Console.WriteLine($"Odpoczywasz. Masz teraz {healing} HP.");
        return healing;
    }
    else
    {
        Console.WriteLine($"Odpoczywasz. Masz teraz {healing} HP.");
        return healing;
    }
}
bool IsGameOver(int health)
{
    bool gameisover = false;
    if(health <= 0)
    {
        gameisover = true;
        return gameisover;
    }
    else
    {
        gameisover = false;
        return gameisover;
    }
}