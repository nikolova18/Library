namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UserBook
    {
        public UserBook(Book bookId, User userId)
        {
            BookId = bookId;
            UserId = userId;
            BorrowDate = DateTime.Now;
        }

        public Book BookId { get; set; }
        public User UserId { get; set; }
        public DateTime BorrowDate { get; set; } //Date and time, represents the date and time when the user has borrowed the book


    }
}
