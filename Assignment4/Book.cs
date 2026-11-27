using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Book
    {
        // Question 01
        private string password = "secret";

        // Question 02
        internal int copiesInStock = 5;

        // Question 03
        public string Title;

        // Question 04
        public Genre Genre { get; set; }
    }
}
