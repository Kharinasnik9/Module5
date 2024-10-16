using System;

class MainClass
{



    public static void Main(string[] args)
    {
        var GetInfo = UserInfoGet();
        UserInfo(GetInfo);

    }



    static (string Name, string LastName, int Age, string[] Pets, string[] Colors) UserInfoGet()
    {
        Console.Write("Введите ваше имя: ");
        string Name = Console.ReadLine();

        Console.Write("Введите вашу фамилию: ");
        string LastName = Console.ReadLine();

        int Age = GetControlNum("Введите ваш возраст: ");

        string[] Pets = null;
        Console.Write("У вас есть питомец? (Да или нет): ");
        bool hasPet = Console.ReadLine()?.ToLower() == "да"; 

        if (hasPet)
        {
            int petCount = GetControlNum("Введите количество питомцев: ");
            Pets = GetPets(petCount);
        }

        int ColorCount = GetControlNum("Введите количество любимых цветов: ");
        string[] Colors = GetColors(ColorCount);

        return (Name, LastName, Age, Pets, Colors);
    }


    static int GetControlNum(string Num)
    {
        int number;
        while (true)
        {
            Console.Write(Num);
            if (int.TryParse(Console.ReadLine(), out number) && number > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Число неверное. Введите целое число положительное число.");
            }
        }
        return number;
    }



    static string[] GetPets(int count)
    {
        string[] petNames = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите кличку питомца {i + 1}: ");
            petNames[i] = Console.ReadLine();
        }
        return petNames;
    }

    static string[] GetColors(int count)
    {
        string[] Colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите название любимого цвета {i + 1}: ");
            Colors[i] = Console.ReadLine();
        }
        return Colors;
    }


    static void UserInfo((string Name, string LastName, int Age, string[] Pets, string[] Colors) userInfo)
    {
        Console.WriteLine("Информация о пользователе");
        Console.WriteLine($"Имя: {userInfo.Name}");
        Console.WriteLine($"Фамилия: {userInfo.LastName}");
        Console.WriteLine($"Возраст: {userInfo.Age}");

        if (userInfo.Pets != null)
        {
            Console.WriteLine("Клички питомцев: " + string.Join(", ", userInfo.Pets));
        }
        else
        {
            Console.WriteLine("У пользователя нет питомцев.");
        }

        Console.WriteLine("Любимые цвета: " + string.Join(", ", userInfo.Colors));
    }
}














