//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram!"

//int - number, Console kirjutab string formaadis, selle probleemi lahendamiseks Int.32

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();
int userAgeNum = 0;
//int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack
//boolean - true/false
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
    { 
        Console.WriteLine("Welcome to Instagram!"); 
    }
    else
    { 
        Console.WriteLine("You are too young to use Instagram."); 
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}