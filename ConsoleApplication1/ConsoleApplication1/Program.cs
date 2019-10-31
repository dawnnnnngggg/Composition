using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p1 = new MyPoint();  // Test constructor
            Console.WriteLine(p1);      // Test toString()
            p1.SetX(8);   // Test setters
            p1.SetY(6);
            Console.WriteLine("x is: " + p1.GetX());  // Test getters
            Console.WriteLine("y is: " + p1.GetY());
            p1.SetXY(3, 0);   // Test setXY()
            Console.Write(p1.GetXY()[0]);  // Test getXY()
            Console.Write(p1.GetXY()[1]);
            Console.Write(p1);

            MyPoint p2 = new MyPoint(0, 4);  // Test another constructor
            Console.Write(p2);
            // Testing the overloaded methods distance()
            Console.WriteLine(p1.Distance(p2));    // which version?
            Console.WriteLine(p2.Distance(p1));    // which version?
            Console.WriteLine(p1.Distance(5, 6));  // which version?
            Console.WriteLine(p1.Distance());      // which version?
            //Author[] authors = new Author[2];
            //authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
            //authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            //// Declare and allocate a Book instance
            //Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
            //Console.WriteLine(javaDummy);  // toString()
            //Author au1 = new Author("dang","lap",'f');
            //Console.WriteLine(au1);
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            //Console.WriteLine(ahTeck);  // Test toString()
            //ahTeck.SetEmail("paulTan@nowhere.com");  // Test setter
            //Console.WriteLine("name is: " + ahTeck.GetName());     // Test getter
            //Console.WriteLine("eamil is: " + ahTeck.GetEmail());   // Test getter
            //Console.WriteLine("gender is: " + ahTeck.GetGender()); // Test gExerciseOOP_MyPolynomial.pngetter
            // Construct an author instance
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            //Console.WriteLine(ahTeck);  // Author's toString()

            //Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);//new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            //Console.WriteLine(dummyBook);  // Test Book's toString()

            //// Test Getters and Setters
            //dummyBook.SetPrice(29.95);
            //dummyBook.SetQty(28);
            //Console.WriteLine("name is: " + dummyBook.GetName());
            //Console.WriteLine("price is: " + dummyBook.GetPrice());
            //Console.WriteLine("qty is: " + dummyBook.GetQty());
            //Console.WriteLine("Author is: " + dummyBook.GetAuthor());  // Author's toString()
            //Console.WriteLine("Author's name is: " + dummyBook.GetAuthor().GetName());
            //Console.WriteLine("Author's email is: " + dummyBook.GetAuthor().GetEmail());

            //// Use an anonymous instance of Author to construct a Book instance
            //Book anotherBook = new Book("more Java", 
            //      new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            //Console.WriteLine(anotherBook);  // toString()
        }
    }
}
