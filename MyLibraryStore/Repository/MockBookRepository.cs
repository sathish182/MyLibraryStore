using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MyLibraryStore.Repository
{
    public class MockBookRepository: IBookRepository
    {
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }
       

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>{
                new Book{Id=1,BookName="First Flight",Author="APJ Abdul Kalam",ISBN="Is1234",PublishedDate=Convert.ToDateTime("11/11/2011")},
                  new Book{Id=2,BookName="World India",Author="Rufson",ISBN="Is6234",PublishedDate=Convert.ToDateTime("12/12/2000")},
                    new Book{Id=1,BookName="Engineering Chemistry",Author="Paneerselvam",ISBN="Is9934",PublishedDate=Convert.ToDateTime("09/11/2014")}

            };
        }

        public void UpdateBook(int? id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
