namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UserBook
    {
        public UserBook(int bookid,int userid)
        {
            BookId = bookid;
            UserId = userid;
            BorrowDate = DateTime.Now;
        }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowDate { get; set; } //Date and time, represents the date and time when the user has borrowed the book

    }
}
