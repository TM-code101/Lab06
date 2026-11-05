

Console.WriteLine("Gracz, wybierz komende 1, 2 , albo 3");

ReadCommand();

string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybór(1,2,3): ");
        string? command = Console.ReadLine();

        switch (command)
        {
            case "1":
            Console.WriteLine("Wybrana komenda 1");
            break;
        
            


            case "2":
            Console.WriteLine("Wybrana komenda 2");
            break;
           

            case "3": 
            Console.WriteLine("Wybrana komenda 3");
            break;
            

            default:
            Console.WriteLine("Nieznana Komenda");
            break;




        }

        // Sprawdź command.
        // Jeśli jest poprawna, zwróć ją przez return.
        // W przeciwnym razie wyświetl komunikat.
    }
}