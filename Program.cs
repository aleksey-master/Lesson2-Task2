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
int number3 = number % 10;
int number2 = number / 10 % 10;
int number1 = number / 100 % 10;

System.Console.WriteLine($"Число с удаленной второй цифрой = {number1}{number3}");
