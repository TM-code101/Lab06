void ShowMessage(string text)
{
    Console.WriteLine(text);
}

int AddGold(int gold, int reward)
{


    return gold + reward;
}



bool HasEnoughGold(int gold, int price) => gold >= price;


ShowMessage("pudge");
AddGold( 3, 1);
HasEnoughGold(3, 2);
Console.WriteLine(ShowMessage);
Console.WriteLine(AddGold(3,1));
Console.WriteLine(HasEnoughGold(3,2));


//Odpowiedzi:
//1: ShowMessage, wyświetla System.Action`1[System.String]
//2: Typu bool (True w moim przykładzie)
//3: int gold dla 10 i int price dla 5 ( w moim przykładzie 3 i 1)
//4: Żeby zrozumieć, czy gracz może kupić przedmiot w sklepie i potem mu to dozwolić