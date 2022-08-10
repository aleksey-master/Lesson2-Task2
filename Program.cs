//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.WriteLine(message);              // Выводит сообщение
    string ReadValue = Console.ReadLine();          // Считывает с консоли строку
    int result = int.Parse(ReadValue);              // Преобразует строку в целое число
    return result;                                  // Возвращает результат функции
};

int number = new Random().Next(10, 1000);
System.Console.WriteLine($"Случайное трехзначное число = {number}");
//int number3 = numberA % 10;
//int number2 = numberA / 10 % 10;
//int number1 = numberA / 100 % 10;
int i = 0;
while (number > 0)
{
    int a = number % 10;
    if (max < a)
        max = a;
        number = number / 10;
i++;
}

System.Console.WriteLine($"Число с удаленной второй цифрой = {number1}{number3}");

