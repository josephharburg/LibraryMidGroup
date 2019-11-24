using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LibraryGroupGiGiRanJo
{
    class Book
    {
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Book() { }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public static void BookToTxtFile(List<Book> books)
        {
            StreamWriter bks = new StreamWriter(@"C:\Users\josep\source\repos\GroupLab\LibraryMidGroup\LibraryGroupGiGiRanJo\Book.txt"); 

            foreach(Book book in books)
            {
                string csv = $"{book.Title},{book.Author}";
                bks.WriteLine(csv);
            }

            bks.Close();
        }
            
    }
}
