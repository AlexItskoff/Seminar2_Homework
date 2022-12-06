//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. Отрицательные числа должны нормально работать.

//-645 -> 5
//645 -> 5
//78 -> третьей цифры нет
//3261279 -> 6

Console. Clear();
Console.WriteLine("Введите  число");

 int number1 = int.Parse(Console.ReadLine()!);

{
  if (number1<0)                      // делаем отрицательное число положительным
   number1 = -number1;
}

if (number1 >-100 && number1 < 100)       // убираем одно и двухзначные числа
Console.WriteLine("третьей цифры нет");

int ci = number1;                             // переводим наше число в строку, чтобы создать
string ac = ci.ToString();                    // массив и получить из него третью цифру
int[] arrInt = new int[ac.Length];             // по индексу 2
for(int n = 0; n < ac.Length; ++n){ 
  arrInt[n] = int.Parse(ac[n]+ "");
  }

  Console.WriteLine(arrInt[2]);






    


    





 
 

 
        

       



             

       




 


 
    
 