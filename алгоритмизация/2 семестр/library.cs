
using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    struct Book
    {
        public string author { get; set; }
        public string nameOfBook { get; set; }
        public int year { get; set; }
        public string publisher { get; set; }


        public List<string> formuliar { get; private set; }
        public bool isFree { get; private set; }

        public Book(string author, string nameOfBook, int year, string publisher)
        {
            this.author = author;
            this.nameOfBook = nameOfBook;
            this.year = year;
            this.publisher = publisher;
            formuliar = new List<string>();
            isFree = true;
        }
        public void getBook()
        {
            if (!isFree)
            {
                Console.WriteLine("Книга не доступна");
                return;
            }
            Console.WriteLine("Введите дату получения книги");
            string data = Console.ReadLine();
            formuliar.Append(data);
            isFree = false;
        }

        public void returnBook()
        {
            if (isFree)
            {
                Console.WriteLine("Книга находится в библиотеке");
                return;
            }
            Console.WriteLine("Введите дату сдачи книги");
            string data = Console.ReadLine();
            formuliar.Append(data);
            isFree = true;
        }

    }
    class Library
    {
        public List<Book> books { get; set; }

        public int countOfBooks { get; private set; }
        public Library(int count)
        {
            countOfBooks = count;
            List<Book> newLibrary = new List<Book>();
            for (int i = 0; i < countOfBooks; i++)
            {
                Console.WriteLine($"Введите данные для {i + 1} книги");

                string author = Console.ReadLine();
                string nameOfBook = Console.ReadLine();
                int year = int.Parse(Console.ReadLine());
                string publisher = Console.ReadLine();


                var newBook = new Book(author, nameOfBook, year, publisher);
                newLibrary.Add(newBook);

            }
            books = newLibrary;
        }


        public List<Book>getNotPopularBooks()
        {
            List <Book> notPopularBooks = new List<Book>();
            for (int i = 0; i < countOfBooks; i++)
            {
                if (!books[i].formuliar.Any())
                {
                    Console.WriteLine($"Книга {books[i].nameOfBook} ни разу не бралась");
                    notPopularBooks.Add(books[i]);
                }
            }
            return notPopularBooks;
        }

        public List<Book> getBusyBooks()
        {
            List<Book> busyBook = new List<Book>();
            for (int i = 0; i < countOfBooks; i++)
            {
                if (!books[i].isFree)   
                {
                    Console.WriteLine($"Книга {books[i].nameOfBook} доступна");
                    busyBook.Add(books[i]);
                }
            }
            return busyBook;
        }

    }



}
