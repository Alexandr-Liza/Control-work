//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.


int length = 0; 
string str = String.Empty;
string result = String.Empty;

Console.WriteLine("Input an array element after each <Enter> press, to complete, press 2 times <Enter>");

while(true) 
{ 
    str = Console.ReadLine();
    if(str == string.Empty) 
    { 
        Console.WriteLine($"String <= three characters: {result}");
        break; 
    } 
    else 
    {
        length = str.Length;
        if(length <= 3)
        {
            result = result + str + ", ";
        }
    }
}