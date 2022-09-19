//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.(456 -> 5, 782 -> 8, 918 -> 1)

    Console.WriteLine("Введите трехзначное число: ");
    int n = int.Parse(Console.ReadLine());

    if (n < 0){
        n = n * (-1);
    };
    if (n > 99 && n < 1000){
        int last2Digit = n % 100;
        int midDigit = last2Digit / 10; 
        Console.WriteLine(midDigit);
    } else {
        Console.WriteLine("Перезапустите программу и введите корректное трезначное число!");
    }


