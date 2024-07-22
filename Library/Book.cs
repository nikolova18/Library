namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Book
    {
        public Book(int id, string title,string author)
        {
            Id = id;
            Title = title;
            Author = author;
            CreateDate = DateTime.Now;
            UpdateTime = null;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }


        public void UpdateBook(string tit,string aut)
        {
            Title = tit;
            Author = aut;
            UpdateTime = DateTime.Now;
        }






    }
}
