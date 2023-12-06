using System;
    public class Program
{ 
        enum m {Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь}
        static void Main()
    {   
        Console.WriteLine("Введите число от 1 до 12.");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x >= 1 && x <= 12)
            Console.WriteLine(x + " месяц - {1}",x,(m)(x - 1));
            else
               Console.WriteLine ("Неправельное число");
    }
}