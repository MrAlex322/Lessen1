Console.Write("Введите ваше имя ");
string username = Console.ReadLine()!;
if (username.ToLower() == "саша")
{ 
    Console.WriteLine("Здарова, Саня!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
