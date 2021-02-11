using System;

namespace Assignment1_SQA
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            int w, l;
            reenter:
            Console.WriteLine("Enter the Width of Rectangle");
            w = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Length of Rectangle");
            l = Int32.Parse(Console.ReadLine());
            r1 = new Rectangle(w, l);
            if(w>0 && l>0)
            {
                int c=0;
                do
                {
                    Console.WriteLine("Select from the Given Choices");
                    Console.WriteLine("1.Get Rectangle Length");
                    Console.WriteLine("2.Change Rectangle Length");
                    Console.WriteLine("3.Get Rectangle Width");
                    Console.WriteLine("4.Change Rectangle Width");
                    Console.WriteLine("5.Get Rectangle Perimeter");
                    Console.WriteLine("6.Get Rectangle Area");
                    Console.WriteLine("7.Exit");
                    c = Int32.Parse(Console.ReadLine());
                    switch(c)
                    {
                        case 1:
                            Console.WriteLine("Length:" +" "+ r1.GetLength());
                            break;
                        case 2:
                            Console.WriteLine("Enter the Length of Rectangle");
                            l = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("New Length:"+" "+ r1.SetLength(l));
                            break;
                        case 3:
                            Console.WriteLine("Width:"+" "+ r1.GetWidth());
                            break;
                        case 4:
                            Console.WriteLine("Enter the Width of Rectangle");
                            w = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("New Width:"+" "+ r1.SetWidth(w));
                            break;
                        case 5:
                            Console.WriteLine("Rectangle Perimiter:"+" "+ r1.GetPerimiter());
                            break;
                        case 6:
                            Console.WriteLine("Rectangle Area:"+" "+ r1.GetArea());
                            break;
                        case 7:
                            Console.WriteLine("Thank You for Using our App");
                            break;
                        default:
                            Console.WriteLine("Invalid Input type Again");
                            break;
                    }
                } while (c != 7);
            }
            else
            {
                Console.WriteLine("Value Should not be less than 1");
                Console.WriteLine("Enter The Correnct Value Again\n");
                goto reenter;
            }
        }
    }
}
