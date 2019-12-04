using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTask3
{
    class Title : IDisplayable
    {
        public string TitleLine { get; set; }

        public Title()
        {

        }
        public Title(string title)
        {
            TitleLine = title;
        }

        public void Show() {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(TitleLine);
        }

    }
}
