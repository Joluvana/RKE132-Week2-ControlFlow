// See https://aka.ms/new-console-template for more information

// küsib kasutja vanust
// kui vanus on noorem kui 13, kuvatakse:
//"You are too young"
//muul juhul kuvatakse "Welcome to"


Console.WriteLine("Enter your age:");

int userAge =Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram");
}