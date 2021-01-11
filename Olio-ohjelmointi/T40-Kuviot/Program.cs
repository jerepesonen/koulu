using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T40_Kuviot
{
    public abstract class Shapes // abstractio luokka shapes
    {
        //ominaisuudet
        public string Name { get; set; }
        //oletuskonstruktori
        public Shapes()
        {
        }

        //abstrctit metodit
        public abstract double Area();
        public abstract double Circumference();
    }
    public class Circle : Shapes // circle luokka periytetty Shapes luokasta
    {
        //ominaisuudet
        public double Radius { get; set; } //säde

        //metodit
        public override double Area()
        {
            return Math.Round(Math.PI * (Radius * Radius),2); // palautetaan säteen perusteella ympyrän pinta-ala
        }
        public override double Circumference()
        {
            return Math.Round(Math.PI * (Radius + Radius),2); // palautetaan säteen perusteella ympyrän kehän pituus
        }
        public override string ToString()
        {
            return $"Circle Radius={Radius} Area={Area()} Circumference={Circumference()}"; // palautetaan kaikki ympyrän tiedot
        }
    }
    public class Rectangle : Shapes // Rectangle luokka periytetty Shapes luokasta
    {
        //ominaisuudet
        public double Width { get; set; } // leveys 
        public double Height { get; set; } // korkeus
        public override double Area()
        {
            return Math.Round((Width * Height),2); // palautetaan leveyden ja korkeuden perusteella neliön pinta-ala
        }
        public override double Circumference()
        {
            return Math.Round((Width * 2 + Height*  2),2);// palautetaan leveyden ja korkeuden perusteella neliön kehän pituus
        }
        public override string ToString()
        {
            return $"{Name} Width={Width} Height={Height} Area={Area()} Circumference={Circumference()}";// palautetaan neliön kaikki tiedot.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan ympyrä ja neliö olioita, ja asetetaan niiden ominaisuuksille arvot
            Circle circle = new Circle() { Name = "Circle", Radius = 1 };
            Circle circle2 = new Circle() { Name = "Circle", Radius = 2 };
            Circle circle3 = new Circle() { Name = "Circle", Radius = 3 };
            Rectangle rectangle = new Rectangle() { Name = "Rectangle", Width = 10, Height= 20};
            Rectangle rectangle2 = new Rectangle() { Name = "Rectangle", Width = 20, Height = 30 };
            Rectangle rectangle3 = new Rectangle() { Name = "Rectangle", Width = 40, Height = 50 };
            
            //lisätään oliot shapes luokan listaan
            List<Shapes> shapes = new List<Shapes> {circle, circle2, circle3, rectangle, rectangle2, rectangle3};

            //käydään listan oliot läpi foreach silmukassa
            foreach (var item in shapes)
            {
                Console.WriteLine(item.ToString()); // kutsutaan olioiden tostring metodia.
            }
            Console.ReadLine();
        }
    }
}
