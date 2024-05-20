using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson39_2
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;

        public Book(string title,string author,int year)
        {
            
            this.title = title;
            this.author = author;
            this.year = year;
        }
        public string getTitle()=>  title;
        public string getAuthor()=> author;
        public int getYear() => year;
    }

}
