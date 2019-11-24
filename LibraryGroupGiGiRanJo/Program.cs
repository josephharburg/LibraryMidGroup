using System;
using System.Collections.Generic;

namespace LibraryGroupGiGiRanJo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>()
            {
                {new Book("HitchHikers Guide to the Galaxy", " Douglas Adams") },
                {new Book("Man’s Search for Meaning"," Victor Frank") },
                {new Book("In search of Schrodinger's Cat"," John Grippin") },
                {new Book("Great Expectations"," Charles Dickens") },
                {new Book("Animal Farm"," George Orwell") },
                {new Book("Time Machine"," H. G.Wells") },
                {new Book("Crime and Punishment"," Fyodor Dostieveski")},
                {new Book("Hunger Games","by Suzanne Collins") },
                {new Book("Harry Potter and the Sorcerer's Stone","J.K Rowling") },
                {new Book("Ready Player One", " Ernest Cline")},
                {new Book("Little Women"," Luisa May Alcott") },
                {new Book("The Martian"," Andy Weir") },
                {new Book("Canticle for Leibovitz","  Herman Miller") },
                {new Book("The Old Man and the Sea","  Ernest Hemingway") },
                {new Book("The Grapes of Wrath"," John Steinbeck" ) },
                {new Book("1984", " George Orwell") },
                {new Book("Lord of the Rings"," J.R.R.Tolkien") },
                {new Book("The Lord of the Flies"," William Golding:") },
                {new Book("The Outsiders","  S.E.Hinton") }
            };
            Book.BookToTxtFile(bookList);
        }
    }
}
