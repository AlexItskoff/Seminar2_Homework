//Задача 15: Напишите программу, которая принимает на вход цифру,
 //обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


Console.WriteLine("Введите число от 1 до 7");

 int number1 = int.Parse(Console.ReadLine()!);
 
 if (number1 >0 && number1 < 6) 
 Console.WriteLine("NO");

  else 
  Console.WriteLine("YES!");



