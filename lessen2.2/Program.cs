﻿void FillArray(int[] collection) //  void ключевое слово означает пустота, называем этот метод "заполниМассив", далее объявляем массив
{   
     int size= collection.Length; //используем переменную размер и кладем в нее функцию длины массива
    int index=0;
    while(index<size)
    {
        collection[index]=new Random().Next(1,10);
        //index=index+1;
        index++;

    }
}
// войд это функция(или метод в контексте языка си шарп)которая не возвращает значений
void PrintArray(int[] col) // используем метод, который будет печатать массив, в качестве аргумента также используем массив 
{
    int count=col.Length; // это также переменная которая обозначает размер, но повторятся нельзя поэтому другое 
    //имя у нее, аналогичное, "колличество", в ней лежит функция длины массива
    int position=0; // это то же что и индекс, но другое имя, это тоже счетчик
    while(position<count)
    {
        Console.WriteLine(col[position]); // то есть то же самое что имя массива и индекс
        position++;  // счетчик, то же что индекс +1 просто другими словами
    }

}

int[] array=new int[10]; // определяем новый массив, используем конструкцию справа, 
//которая означает создай новый массив, в котором будет 10 элементов, 
//по умолчанию, он будет наполнен нулями, чтобы это изменить смотри выше
FillArray(array);
PrintArray(array);