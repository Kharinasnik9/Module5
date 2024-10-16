using System;

class MainClass
{



    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");

        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");

        var deep = int.Parse(Console.ReadLine());


        Echo(str, deep);

    }

    static void Echo(string saidworld, int deep)
    {
        var modif = saidworld;

        if (modif.Length > 2)
        {

            modif = modif.Remove(0, 2);
        }

        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }

    }




    //public static void Main(string[] args)
    //{

    //    var arr = new int[] { 1, 2, 3 };
    //    BigDataOperation(arr);

    //    Console.WriteLine(arr[0]);

    //}

    //static void BigDataOperation(int[] arr)
    //{
    //    arr[0] = 4;
    //}




    //    public static void Main(string[] args)
    //    {

    //        var (name, age) = ("Никита", 27);

    //        Console.WriteLine("Мое имя: {0}", name);
    //        Console.WriteLine("Мой возраст: {0}", age);

    //        Console.Write("Введите имя: ");
    //        name = Console.ReadLine();
    //        Console.Write("Введите возрас с цифрами:");
    //        age = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Ваше имя: {0}", name);
    //        Console.WriteLine("Ваш возраст: {0}", age);

    //        var favcolors = new string[3];

    //        for (int i = 0; i < favcolors.Length; i++)

    //        {
    //            favcolors[i] = ShowColor(favcolors);
    //        }

    //        Console.WriteLine("Ваши любимые цвета"); 
    //        foreach (var color in favcolors)
    //        {
    //            Console.WriteLine(color);
    //        }


    //        Console.ReadKey();


    //    }







    //    static string ShowColor(string[] favcolors)
    //    {
    //        Console.WriteLine("{0}, {1} лет  \nНапишите свой любимый цвет на английском с маленькой буквы" , username, userage);
    //        var color = Console.ReadLine();

    //        switch (color)
    //        {
    //            case "red":
    //                Console.BackgroundColor = ConsoleColor.Red;
    //                Console.ForegroundColor = ConsoleColor.Black;

    //                Console.WriteLine("Your color is red!");
    //                break;

    //            case "green":
    //                Console.BackgroundColor = ConsoleColor.Green;
    //                Console.ForegroundColor = ConsoleColor.Black;

    //                Console.WriteLine("Your color is green!");
    //                break;
    //            case "cyan":
    //                Console.BackgroundColor = ConsoleColor.Cyan;
    //                Console.ForegroundColor = ConsoleColor.Black;

    //                Console.WriteLine("Your color is cyan!");
    //                break;
    //            default:
    //                Console.BackgroundColor = ConsoleColor.Yellow;
    //                Console.ForegroundColor = ConsoleColor.Red;

    //                Console.WriteLine("Your color is yellow!");
    //                break;


    //        }

    //        return color;
}






