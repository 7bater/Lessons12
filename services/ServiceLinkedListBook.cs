using System.Collections.Generic;
using Lessons12.models;

namespace Lessons12.services
{
    public class ServiceLinkedListBook
    {
        public LinkedList<Book> Books { get; set; }

        public ServiceLinkedListBook(LinkedList<Book> books)
        {
            Books = books;
        }

        public void AddFirst(Book book) => Books.AddFirst(book);
        public void AddLast(Book book) => Books.AddLast(book);

        public void RemoveFirst()
        {
            if (Books.First != null) Books.RemoveFirst();
        }

        public void RemoveLast()
        {
            if (Books.Last != null) Books.RemoveLast();
        }

        public void Remove(Book book) => Books.Remove(book);
    }
}