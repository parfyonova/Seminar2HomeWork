﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем
456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if((num < 100) || (num > 999)){
    Console.WriteLine("Введено не трехзначное число");
}
else{
    int num1 = num/10;
    int num2 = num1%10;
    Console.WriteLine($"Вторая цифра вашего трехзначного числа {num} это {num2}");
}
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
Console.WriteLine("Введите число до 100000: ");
int num = int.Parse(Console.ReadLine()!);
if(num < 100){
    Console.WriteLine($"В числе {num} нет третьей цифры");
}
else{
    if((num > 99) && (num < 1000)){
        int num1 = num%10;
        Console.WriteLine($"Третья цифра числа {num} это {num1}");
    }
    else{
        if((num > 999) && (num < 10000)){
            int num21 = num/10;
            int num22 = num21%10;
            Console.WriteLine($"Третья цифра числа {num} это {num22}");
        }
        else{
            if((num > 9999) && (num < 100000)){
                int num31 = num/100;
                int num32 = num31%10;
            Console.WriteLine($"Третья цифра числа {num} это {num32}");
            }
        }
    }
    Console.WriteLine("Необходимо ввести число до 100000");
}
*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7
6 -> да
7 -> да
1 -> нет
*/
/*
Console.WriteLine("1 - Понедельник, 2 - Вторник, 3 - Среда, 4 - Четверг, 5 - Пятница, 6 - Суббота, 7 - Воскресенье");
Console.WriteLine("Введите число от 1 до 7, которое соответсвует проверяемому дню недели: ");
int day = int.Parse(Console.ReadLine()!);
if((day < 1) || (day > 7)){
    Console.WriteLine("Дня недели с таким номером не существует, необходимо вводить чисо от 1 до 7");
}
if((day > 0) && (day < 6)){
    Console.WriteLine($"День под номером {day} не является выходным");
}
if((day == 6) || (day == 7)){
    Console.WriteLine($"День под номером {day} является выходным");
}
*/