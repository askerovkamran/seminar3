// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string num = (Console.ReadLine()!);

void pol(string num){
  
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Ваше число: {num} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {num} - НЕ палиндром.");
}

if (num!.Length == 5)
{
  pol(num);
}
else Console.WriteLine($"Введи правильное число");