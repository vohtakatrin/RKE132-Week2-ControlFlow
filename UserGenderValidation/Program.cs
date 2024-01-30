Console.WriteLine("Hello, Katrin!");
//rakendus küsib kasutajal valida oma sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonanimi]" / "Welcome, Ms. [kasutaja perekonanimi]"

Console.WriteLine("Please, select your gender (m/f)");
char userGender = Char.Parse(Console.ReadLine()); //loeb maha andmeid string formaadis

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}, uknow gender user!");
}
//else
//{
// Console.WriteLine("Welcome!");
//}