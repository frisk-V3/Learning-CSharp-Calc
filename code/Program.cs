using System;

class Prpgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("1つ目の数字を入力してください");
        int num1 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("2つ目の数字を入力してください");
        int num2 = int.Parse(Console.ReadLine()!);

        int sum = num1 + num2;
        Console.WriteLine($"足し算の結果は{sum}です!");

    }
}
