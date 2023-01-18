//Задача №25
// программa, которая возводит число А в натуральную степень В
/*
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {a} в степени {b} равно {GetMultiplay(a,b)}");

// -------Методы-------

int GetMultiplay(int a, int b){
    int mult = 1;
    for(int i = 1; i <= b; i++){
        mult = mult * a;
    }
    return mult;
}
*/



//Задача № 27
// программа, принимает на вход число и выдает сумму цифр в числе
/*
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine($"Сумма цифр в числе  {num} равнa {sum_of_digits(num)}");


int sum_of_digits(string num)
{
    int result = 0; 
    int i = 0;
    while (num.Length > i)
    {
        string b = num[i].ToString();
        int a = Convert.ToInt32(b);
        result = result + a;
        i = i + 1;
    }
    return result;
}
*/





// Задача №29
// программа, которая задает массив из 8 элементов
/*
int[] myArray = GetArray (8);
Console.WriteLine($"[{String.Join(',', myArray)}]");


// ---методы---заполнения массива
int [] GetArray(int size){
    int[] myArray = new int [size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(1001);
    }
    return myArray;
}

*/
