using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pies p1 = new Pies(4, Rasa.Blablador, "Azorek");
            Pies p2 = new Pies(1, Rasa.Owczarek, "Reks");
            Pies p3 = new Pies(8, Rasa.Kundelek, "Ciapek");
            Pies p4 = new Pies(15, Rasa.Collie, "Lady");
            Pies p5 = new Pies(10, Rasa.Golden, "Ciastek");

            cw(p1.Imie);
            cr();
            cw(p2.Imie);
            cr();
            cw(p3.Imie);
            cr();
            cw(p4.Imie);
            cr();
            cw(p5.Imie);
            cr();
        }

        public static void cw(string input)
        {
            Console.WriteLine(input);
        }

        public static void cr()
        {
            Console.ReadKey();
        }
    }

    class Pies
    {
        public Pies(int wiek, Rasa rasa, string imie)
        {
            Wiek = wiek;
            Rasa = rasa;
            Imie = imie;
        }

        public int Wiek { get; set; }
        public Rasa Rasa { get; set; }
        public string Imie { get; set; }
    }

    enum Rasa
    {
        Collie,
        Kundelek,
        Golden,
        Blablador,
        Owczarek
    }
}
