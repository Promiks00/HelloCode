﻿Console.WriteLine("ВВедите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "masha")
{
    Console.WriteLine("Ура! Это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
} 