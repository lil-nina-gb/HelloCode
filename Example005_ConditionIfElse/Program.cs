Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "тоня")
{
    Console.WriteLine("Ура,Тоня!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}