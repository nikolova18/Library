namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LibraryManagment
    {
        private Dictionary<int, Book> books = new Dictionary<int, Book>();
        private Dictionary<int, User> users = new Dictionary<int, User>();
        private List<UserBook> userBooks = new List<UserBook>();

        private int bookId = 1;
        private int userId = 1;

        public void AddBook(string title,string author)
        {
            int id = bookId++;
            //if(books.ContainsKey(id))
            //{
            //    Console.WriteLine("Book with this ID already exist.");
            //    return;
            //}
            books[id] = new Book(id, title, author);
            Console.WriteLine("Book added successfully.");
        }
        public void AddUser(string fn,string ln)
        {
            int id = userId++;
            if (users.ContainsKey(id))
            {
                Console.WriteLine("User with tihs ID already exist.");
            }
            users[id] = new User(id, fn, ln);
            Console.WriteLine("User added successfully.");
        }
        public void GetUser(int id)
        {
            if(users.TryGetValue(id,out User user))
            {
                Console.WriteLine($"User ID: {user.Id} - First name: {user.FirstName} - Last name: {user.LastName} - Last updated: {user.UpdateTime}");
            }
            else { Console.WriteLine("User not found."); }

        }
        public void GetBook(int id)
        {
            if(books.TryGetValue(id,out Book book))
            {
                Console.WriteLine($"Book ID: {book.Id} - Name: {book.Title} - Author: {book.Author} - Last updated: {book.UpdateTime}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public void UpdateBook(int id,string title,string author)
        {
            if(books.TryGetValue(id,out Book book))
            {
                book.UpdateBook(title, author);
            }
            else Console.WriteLine("Book not found.");
        }
        public void UpdateUser(int id,string fn,string ln)
        {
            if(users.TryGetValue(id,out User user))
            {
                user.UpdateUser(fn, ln);
            }
            else Console.WriteLine("User not found.");
        }
        public void DeleteBook(int id)
        {
            if(books.Remove(id))
            {
                userBooks.RemoveAll(ub => ub.BookId == id);
                Console.WriteLine("Book removed.");
            }
            else Console.WriteLine("Book not found.");
        }
        public void DeleteUser(int id)
        {
            if(users.Remove(id))
            {
                userBooks.RemoveAll(ub => ub.UserId == id);
                Console.WriteLine("User removed.");
            }
            else Console.WriteLine("User not found.");
        }
        public void BorrowBook(int BookId,int UserId)
        {
            if(!users.ContainsKey(UserId))
            {
                Console.WriteLine("User not found.");
                return;
            }
            if(userBooks.Exists(ub=>ub.UserId==UserId))
            {
                Console.WriteLine("User has already borrow a book.");
                return;
            }
            if(!books.ContainsKey(BookId))
            {
                Console.WriteLine("Book not found.");
                return;
            }
            if(userBooks.Exists(ub=>ub.BookId==BookId))
            {
                UserBook ub = userBooks.Find(ub => ub.BookId == BookId);
                User user = users[ub.UserId];
                Console.WriteLine($"The book that you are trying to borrow is already borrowed by user {user.FirstName} {user.LastName} on {ub.BorrowDate}");
                return;
            }
            userBooks.Add(new UserBook(BookId, UserId));
            Console.WriteLine("Book borrowed successfully.");
        }
        public void ReturnBook(int UserId,int BookId)
        {
            UserBook ub = userBooks.Find(ub => ub.BookId == BookId && ub.UserId==UserId);
            if (ub!=null)
            {
                userBooks.Remove(ub);
                Console.WriteLine("Book returned.");
            }
            else
            {
                Console.WriteLine("Book not borrowed by this user.");
            }
        }
    }
}
