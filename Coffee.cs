using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeTypes;

public class FiveCofe
{
    public bool Sugar { get; set; }
    public bool Water { get; set; }
    public string Milk { get; set; }
    public bool Ice { get; set; }

    public FiveCofe()
    {
        Console.WriteLine("Пожалуйста Ваш Чёрный, без всего!!!");
    }

    public FiveCofe(bool water)
    {
        Water = water;
        Console.WriteLine("Пожалуйста Ваш Американо!");
    }

    public FiveCofe(bool sugar, string milk)
    {
        Sugar = sugar;
        Milk = milk;
        Console.WriteLine("Пожалуйста Ваш Купучино!");
    }

    public FiveCofe(bool sugar, bool water, string milk)
    {
        Sugar = sugar;
        Water = water;
        Milk = milk;
        Console.WriteLine("Пожалуйста Ваш Раф!");
    }

    public FiveCofe(bool sugar, bool water, string milk, bool ice)
    {
        Sugar = sugar;
        Water = water;
        Milk = milk;
        Ice = ice;
        Console.WriteLine("Пожалуйста Ваш Фраппе!");
    }
}