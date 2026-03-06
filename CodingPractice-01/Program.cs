using System;
using System.ComponentModel;

class CodPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3();
        //Prac_4();
        //Prac_5();
        //Prac_6();
        //Prac_7();
        //Prac_8();
        //Prac_9();
        Prac_10();
    }

    static void Prac_1()
    {
        Priority priority = Priority.High;

        if (priority == Priority.High)
        {
            Console.WriteLine("높은 우선순위");
        }
    }

    static void Prac_2()
    {
        Animal animal = Animal.Tiger;
        Console.WriteLine(animal);
        if (animal == Animal.Tiger)
        {
            Console.WriteLine("호랑이");
        }

    }
    static void Prac_3()
    {
        int red = (int)Color.Red;
        int green = (int)Color.Green;
        int blue = (int)Color.Blue;

        Console.WriteLine($"Red: {red}, Green : {green}, Blue: {blue}");
    }
    static void Prac_4()
    {
        Console.WriteLine(sizeof(SmallEnum));


    }

    static void Prac_5()
    {
        Type type = typeof(ConsoleColor);

        string[] colors = Enum.GetNames(type);
        for (int i = 0; i < colors.Length; i++)

        {
            Console.WriteLine(colors[i]);
        }
    }

    static void Prac_6()
    {
        string colorName = "Red";

        
        ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);

        Console.ForegroundColor = color;
        Console.WriteLine("빨간색 텍스트");
        Console.ResetColor();
        Console.WriteLine("기본 색상 텍스트");
    }

    static void Prac_7()
    {
        string input1 = "Up";

        if (Enum.TryParse(input1, out Direction direction))
        {
            Console.WriteLine($"반환 성공 : {direction}");
        }
        else
        {
            Console.WriteLine("반환 실패");
        }

        string invalid = "Forward";

        if (Enum.TryParse(invalid, out Direction result))
        {
            Console.WriteLine($"반환 성공 : {result}");
        }
        else
        {
            Console.WriteLine($"'{invalid}'은(는) 유효하지 않은 값");
        }
    }
    static void Prac_8()
    {
        bool Isvalid1 = Enum.IsDefined(typeof(Animal),1);
        bool Isvalid2 = Enum.IsDefined(typeof(Animal), 100);
        bool Isvalid3 = Enum.IsDefined(typeof(Animal), "Tiger");

        Console.WriteLine($"1은 유효한 Animal 값인가? {Isvalid1}");
        Console.WriteLine($"100은 유효한 Animal 값인가? {Isvalid2}");
        Console.WriteLine($"'Tiger'은 유효한 Animal 값인가? {Isvalid3}");
    }
    static void Prac_9()
    {
        Direction dir = Direction.Right;
        int num = (int)dir;
        Console.WriteLine($"Right = {num}");
        int value = 2;
        Direction dir2 = (Direction)value;
        Console.WriteLine($"2 = {dir2} ");
    }
    static void Prac_10()
    {
        Animal invalid = (Animal)100;
        Console.WriteLine(invalid);
    }

}
enum Priority
{
    High,
    Normal,
    Low
}

enum Animal
{
    Mouse,
    Cow,
    Tiger
}

enum Color
{
    Red = 10,
    Green, 
    Blue = 20
}

enum SmallEnum : byte
{
    Left,
    Right,
    Top,
    Bottom
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}