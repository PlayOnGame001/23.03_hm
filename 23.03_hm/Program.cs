using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03_hm
{
    interface Pizza
    {
        string Form();
        string Testo();
        string Ingridien();
    }
    class Paperonni : Pizza
    {
        public string Form()
        {
            return "Паперони";
        }
        public string Testo()
        {
            return "109см";
        }
        public string Ingridien()
        {
            return "Кетчуп, сыр, огурчики, охотничьи колбасы";
        }
    }
    class Margarita : Pizza
    {
        public string Form()
        {
            return "Маргарита";
        }

        public string Testo()
        {
            return "98см";
        }

        public string Ingridien()
        {
            return "Ананасы, кукуруза, сыр, кетчеп, мясо(на выбор)";
        }
    }
    class Diablo : Pizza
    {
        public string Form()
        {
            return "Дьябло";
        }
        public string Testo()
        {
            return "110 см";
        }
        public string Ingridien()
        {
            return "Перец чили, острые приправы, мясо, сыр, кетчуп, колбасы";
        }
    }
    class Pizzza
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Product parts: " + str + "\n";
        }
    }
    class Director
    {
        private Pizza auto;

        public Pizza BuildAuto
        {
            set { auto = value; }
        }
        public void ShowElements()
        {
            Console.WriteLine($"Form: {auto.Form()}");
            Console.WriteLine($"Testo: {auto.Testo()}");
            Console.WriteLine($"Ingridien: {auto.Ingridien()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var daewoo = new Paperonni();
            director.BuildAuto = daewoo;
            director.ShowElements();
            Console.WriteLine();
            var volks = new Diablo();
            director.BuildAuto = volks;
            director.ShowElements();

        }
    }
}