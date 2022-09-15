// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutaja sugu
//rakendus küsib kasutajanime
// lähtudes kasutaa valikust tervitab rakendus teda
// "Welcome, MR. [kasutaja perekonnanimi]/ "welcome, MS.[kasutaja perekonnanimi]

Console.WriteLine("Please, select your gender(m/f):");

char userGender =Char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your last name:");

String userLastname = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastname}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastname}!");
}