using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box
{
    public float heigth;
    public float width;
    public float length;

    public void Show()
    {
        Console.WriteLine("Высота: " + heigth);
        Console.WriteLine("Ширина: " + width);
        Console.WriteLine("Длина: " + length);
    }

    public float Volume()
    {
        return heigth * width * length;
    }
}
class Program
{
    static void Main()
    {
        Box box = new Box();

        box.width = 2;
        box.heigth = 3;
        box.length = 5;

        Console.WriteLine("Данные о коробке: ");
        box.Show();

        float volume = box.Volume();
        Console.WriteLine("Обьем коробки: " + volume);
        Console.ReadLine();
    }
}
