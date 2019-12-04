using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask3
{
    class Content : IDisplayable
    {
        string ContentText { get; set; }
        public Content(string content)
        {
            ContentText = content;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(ContentText);

        }
    }
}
