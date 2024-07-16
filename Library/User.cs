namespace Library
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User
    {
        public User(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreateDate = DateTime.Now;
            UpdateTime = null;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }


    }
}
