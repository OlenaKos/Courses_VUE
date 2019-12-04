using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClassesTask3
{
    class Book
    {
        public Title title {get; set;}
        public Author author { get; set; }
        public Content content { get; set; }
        public Book()
        {

        }
        public Book(Title curtitle, Author curauthor, Content curcontent)
        {
            title = curtitle;
            author = curauthor;
            content = curcontent;
        }

        public void Show()
        {
            List<IDisplayable> properties = new List<IDisplayable> { title, author, content };
            foreach (var property in properties)
            {
                property.Show();
            }
        }
    }
}
