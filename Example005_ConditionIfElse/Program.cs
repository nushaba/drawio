Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") //ToLower() переводит все буквы в нижний регистр
{
	Console.WriteLine("Ура, это же МАША!");
}
else
{
	Console.Write("Привет, ");
	Console.Write(username);
}