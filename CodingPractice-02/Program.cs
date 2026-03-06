using System;

// README.md를 읽고 아래에 코드를 작성하세요.
class CodPrac
{
    static void Main()
    {
        //Prac_1();
        Prac_2();
    }

    static void Prac_1()
    {
        Animal dragon = Animal.Dragon;
        int value = (int)dragon;
        string str = dragon.ToString();

        Console.WriteLine($"Animal.Dragon: {value}, {str}");
        
    }
    static void Prac_2() 
    {
        Array values = Enum.GetValues(typeof(Priority));
        Console.WriteLine("Priority 열거형의 값들:");
        foreach (Priority value in values)
        {
            Console.WriteLine($"{value} = {(int)value}");
        }

    }
}

enum Animal
{
    Rabbit,
    Dragon,
    Snake
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}