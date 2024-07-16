namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Book
    {
        public Book(int id, string title)
        {
            Id = id;
            Title = title;
            CreateDate = DateTime.Now;
            UpdateTime = null;
            IsBorrow = false;
        }

        public bool IsBorrow { get; private set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }


        public void UpdateBook()
        {

        }






    }
}
