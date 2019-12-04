using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask3
{
    class Author : IDisplayable
    {
        public string AuthorName { get; set; }
        public Author()
        {

        }
        public Author(string author)
        {
            AuthorName = author;
        }
        public void Show()
        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(AuthorName);

        }
    }
}
