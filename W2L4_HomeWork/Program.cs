using System;

namespace W2L4_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sebastian";
            string surname = "Wywijas";
            int Age = 37;
            char Gender = 'm';
            long ID = 84011766666;
            long EmployeeNumber = 135206;

            Console.WriteLine("Program 1\n");

            Console.WriteLine("Name, Surname: " + name + " " + surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("ID: " + ID); 
            Console.WriteLine("Nr pracownika: " + EmployeeNumber);

            Console.WriteLine("\nProgram 2\n");

            string a, b, c;
            a = "A";
            b = "B";
            c = "C";

            Console.WriteLine("Zmienna " + c);
            Console.WriteLine("Zmienna " + b);
            Console.WriteLine("Zmienna " + a);

            Console.WriteLine("\nProgram 3\n");

     
            double aa;
            double bb;
            double diagonal;

            Console.WriteLine("Oblicz długość przekątnej");
            Console.WriteLine("Podaj szerokość prostokata:");
            double w = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długośc prostokata:");
            double h = Double.Parse(Console.ReadLine());

            aa = Math.Pow(w, 2);
            bb = Math.Pow(h, 2);

            diagonal = Math.Sqrt(aa + bb);
                
            Console.WriteLine("Diagonal from Pitagoras: " + diagonal);

            Console.WriteLine("\nProgram 4\n");

            int number1 = 10;
            string myname = "Szkoła Dotneta";
            float myreal = 12.5f;

            Console.WriteLine("This is INTEGER: " + number1);
            Console.WriteLine("This is STRING: " + myname);
            Console.WriteLine("This is REAL: " + myreal);

            Console.WriteLine("\nProgram 5\n");

            Console.WriteLine("Podaj swoje imie:");
            string yourName = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko:");
            string yourSurName = Console.ReadLine();
            Console.WriteLine("Podaj swoje nr telefonu:");
            long yourPhoneNr = long.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj adres email:");
            string yourEmail = Console.ReadLine();
            Console.WriteLine("Podaj swoj wzrost:");
            float yourHeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoja wagę:");
            float yourWeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj ulubiony kolor:");
            string yourColour = Console.ReadLine();


        }
    }
}
