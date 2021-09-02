using System;
using System.Collections;
using System.Collections.Generic;

namespace BooksAndBooks
{
    class Book
    {
        private string name;
        private int bookId;

        public Book(string name_, int bookId_)
        {
            this.name = name_;
            this.bookId = bookId_;
        }

        public void Print()
        {
            Console.WriteLine("Book name:   " + name);
            Console.WriteLine("Book ID:     " + bookId +" :");
        }
    }

    class Guest
    {
        private int guestId;
        private string guestUserName;

        public int guestId_
        {
            get { return guestId; }
            set { guestId = value; }
        }
        public string guestUserName_
        {
            get { return guestUserName; }
            set { guestUserName = value; }
        }

        public void UserPrint()
        {            
            Console.WriteLine($"Guest Id: {guestId} :");
            Console.WriteLine($"Guest User name: {guestUserName} :");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> libary = new List<Book>();

            Book biologi = new Book("Biologi for dummies!", 1001);
            Book math = new Book("Math is for losers and here is why", 1002);
            Book twilight = new Book("Vampires hate werewolfs cause reasons...", 1003);
            Book hobbit = new Book("Dwarfs and where to find them", 1004);
            Book deo = new Book("Matematernes gud pytagi!", 1005);
            Book dnD = new Book("build your own Dungeon, and learn to subduct", 1006);

            libary.Add(biologi);
            libary.Add(math);
            libary.Add(twilight);
            libary.Add(hobbit);
            libary.Add(deo);
            libary.Add(dnD);


            Console.WriteLine("====================================================\n" +
                              "|                                                   |\n" +
                              "|          Books Currently in The libary            |\n" +
                              "|                                                   |\n" +
                              "====================================================");
            Console.WriteLine();


            Console.WriteLine($"\nBooks currently in stock {libary.Count}");


            foreach (Book book in libary)
            {
                Console.WriteLine();
                book.Print();
            }

            Console.ReadKey();

            List<Guest> users = new List<Guest>();

            Guest emilie = new Guest();
            emilie.guestId_ = 2202;
            emilie.guestUserName_ = "Emem2005";

            users.Add(emilie);

            Console.WriteLine("========================================================");
            Console.WriteLine("logged on user: " +
                              "\n================");
            emilie.UserPrint();
            Console.WriteLine("========================================================");

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("====================================================\n"+
                              "|                                                   |\n"+
                              "|                  Books going out                  |\n"+
                              "|                                                   |\n"+
                              "====================================================");
            Console.WriteLine();

            Console.ReadKey();

            Stack<Book> bookstack = new Stack<Book>();

            bookstack.Push(biologi);
            bookstack.Push(math);
            bookstack.Push(deo);
            libary.Remove(biologi);
            libary.Remove(math);
            libary.Remove(deo);

            Console.WriteLine($"Books to borrow: {bookstack.Count}");

            foreach (Book book in bookstack)
            {
                Console.WriteLine();
                book.Print();
            }

            Console.ReadKey();

            Console.WriteLine("\nAre you sure?");

            Console.WriteLine();

            Console.ReadKey();

            while (bookstack.Count > 0) 
            {
                Console.WriteLine("========================================="+
                                  "\nBook borrowed");
                Book a = bookstack.Peek();
                a.Print();
                bookstack.Pop();
            }

            Console.WriteLine("========================================="+
                              $"\nbooks left in stack : {bookstack.Count}"+
                              "\n=========================================");


            Console.WriteLine($"\nBooks currently in stock {libary.Count}");
            
            foreach (Book book in libary)
            {
                Console.WriteLine();
                book.Print();
            }

            Console.ReadKey();
        }
    }
}
