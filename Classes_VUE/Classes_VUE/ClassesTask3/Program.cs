using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3
            Author author = new Author("Agatha Christie");
            Title title = new Title("Ten little Indians");
            Content content = new Content("Ten little Soldier Boys went out to dine; One choked his little self and then there were nine.");

            Book book = new Book(title, author, content);
            book.Show();

            Console.ReadLine();

        }
    }
}
