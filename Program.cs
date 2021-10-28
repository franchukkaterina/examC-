using System;
using System.IO;
using System.Xml.Serialization;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            FileModeOpenOrCreate file = new FileModeOpenOrCreate();

            MySystem<Laptop> list = new MySystem<Laptop>();
            list.Add(new Laptop(30000, "MacBook", 20 ,128, "AMD"));
            list.Add(new Laptop(30000, "MacBook", 20 ,256, "AMD"));
            list.Add(new Laptop(54000, "Asus", 30 ,256, "Intel"));
            list.Add(new Laptop(24000, "Acer", 5 ,32, "AMD"));
            list.Add(new Laptop(54000, "Asus", 30 ,128, "Intel"));

            file.RecordInformation(list);

            file.GetInformation();
            
            list.ForEach(Console.WriteLine);

            list.Remove(new Laptop(30000, "MacBook", 20 ,128, "AMD"));

            Console.WriteLine($"\n");
            

            list.ForEach(Console.WriteLine);

            list.Clear();

            Console.WriteLine($"\n\n");
            

            list.ForEach(Console.WriteLine);

        }
    }
}
