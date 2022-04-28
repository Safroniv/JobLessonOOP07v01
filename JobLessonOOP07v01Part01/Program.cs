using System;

namespace JobLessonOOP07v01Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ACoder - Метод кодирования строки с увеличением/уменьшением значения +1/-1");
            ACoder aCoder = new ACoder();
            Console.WriteLine(aCoder.Encode("АБВгдеЯ"));
            Console.WriteLine(aCoder.Encode("ABCdefZ"));
            Console.WriteLine(aCoder.Encode("Привет Мир!@#$^^&><?"));
            Console.WriteLine(aCoder.Decode(aCoder.Encode("АБВгде")));
            Console.WriteLine(aCoder.Decode("Hallo World!"));
            Console.WriteLine(aCoder.Decode(aCoder.Encode("Hallo World! !@$#^&^%*")));
            Console.WriteLine(aCoder.Decode("ABCDefgza !@$#^&^%*"));
            //Console.WriteLine("====== Введите строку======");
            //Console.WriteLine(aCoder.Encode(Console.ReadLine()));

            Console.WriteLine("BCoder - Метод кодирования строки с заменой i-й позиции, на букву на i-й позиции с конца алфавита");
            BCoder bCoder = new BCoder();
            Console.WriteLine(bCoder.Encode("ABCDEFGHIJKLMNOPQRSTYVWXYZ !@$#^&^%*"));
            Console.WriteLine(bCoder.Encode("АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЪЬЫЭЮЯ !@$#^&^%*"));
            Console.WriteLine(bCoder.Encode("абвгдэюя"));
            Console.WriteLine(bCoder.Decode("АБВэюя"));

            //Console.WriteLine("====== Введите строку======");
            //Console.WriteLine(bCoder.Encode(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}
