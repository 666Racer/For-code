Console.Write("Введитя имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лера")
{
    Console.WriteLine("Ура, это же ЛЕРА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}