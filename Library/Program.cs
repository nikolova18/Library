namespace Library
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            LibraryManagment lm = new LibraryManagment();

            

            bool running = true;

            while(running)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("-------------------------");
                Console.WriteLine("| Option | Description                          |");
                Console.WriteLine("|--------|--------------------------------------|");
                Console.WriteLine("| 1      | Add User                             |");
                Console.WriteLine("| 2      | Add Book                             |");
                Console.WriteLine("| 3      | Get User                             |");
                Console.WriteLine("| 4      | Get Book                             |");
                Console.WriteLine("| 5      | Update User                          |");
                Console.WriteLine("| 6      | Update Book                          |");
                Console.WriteLine("| 7      | Delete User                          |");
                Console.WriteLine("| 8      | Delete Book                          |");
                Console.WriteLine("| 9      | Borrow Book                          |");
                Console.WriteLine("| 10     | Return Book                          |");
                Console.WriteLine("| 0      | Exit                                 |");
                Console.WriteLine("-------------------------");
                Console.Write("Choose an option: ");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first and last name");
                        lm.AddUser(Console.ReadLine(), Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Enter title and author");
                        lm.AddBook(Console.ReadLine(), Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter user ID");
                        lm.GetUser(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter book ID");
                        lm.GetBook(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("Enter user Id, new first and/or last name");
                        lm.UpdateUser(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Enter book Id, new title and/or author");
                        lm.UpdateBook(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());                        
                        break;
                    case 7:
                        Console.WriteLine("Enter user ID you want to delete.");
                        lm.DeleteUser(int.Parse(Console.ReadLine()));
                        break;
                    case 8:
                        Console.WriteLine("Enter book ID you want to delete.");
                        lm.DeleteBook(int.Parse(Console.ReadLine()));
                        break;
                    case 9:
                        Console.Write("Enter User ID: ");
                        int userId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        lm.BorrowBook(bookId, userId);
                        break;
                    case 10:
                        Console.Write("Enter User ID: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Book ID: ");
                        bookId = int.Parse(Console.ReadLine());
                        lm.ReturnBook(userId, bookId);
                        break;

                    case 0:
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                }
            }
        }
    }
}
