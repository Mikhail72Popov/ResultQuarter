// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] ar1; 
int count; 
Console.Write("Введите количество строк: ");
count = Int32.Parse(Console.ReadLine());
ar1 = new string[count];
void Main(string[] args)
  {
    Console.WriteLine("Введите строки массива:");
      for (int i=0; i<ar1.Length; i++)
        {
          Console.Write("Строка[{0}] = ", i);
          ar1[i] = Console.ReadLine();
        }
    
    string[] ar2 = new string[ar1.Length];
    int a = 0;
      for (int i = 0; i < ar1.Length; i++)
        {    
          if(ar1[i].Length < 4)
              {
                ar2[a] = ar1[i];
                a++;
              }
        }

    Console.WriteLine("Строки длина которых <= 3:");
      for (int i = 0; i < a; i++)
        {
          Console.Write($"'{ar2[i]}' ");
        }
    Console.WriteLine();
  }

Main(ar1);
