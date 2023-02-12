// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. При решение не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

//Console.WriteLine("ВВЕДИТЕ МАССИВ: ");

string[] array1 = new string[5] {"MOSCOW" , "69" , "6" , "DAGESTAN " , "05"  };
string[] array2 = new string[array1.Length];

void Array(string[] array1, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
     if(array1[i].Length <= 3) //количество элементов в массиве должно быть меньше или рвано трём
     {
        array2[count] = array1[i];
        count++;
     }
  }

}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
         Console.Write($" КОНЕЧНЫЙ РЕЗУЛЬТАТ: {array[i]}");
    }
    Console.WriteLine();
}

Array(array1 , array2);
PrintArray(array2);
