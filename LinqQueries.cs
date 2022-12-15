using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace C__Learning_Linq
{
    public class LinqQueries
    {
        private List<Book> booksList = new List<Book>();
        public LinqQueries()
        {
            using (StreamReader reader = new StreamReader("books.json"))
            {
                string jsonfile = reader.ReadToEnd();                
                this.booksList = JsonSerializer.Deserialize<List<Book>>(jsonfile, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                }) ?? Enumerable.Empty<Book>().ToList();
            }            
        }
    public IEnumerable<Book> GetBooks()
    {
        return booksList;
    }

    public void printBooks()
    {
        Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Title", "Pages", "Published");
        this.booksList.ForEach(x => Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", 
        x.Title,
        x.PageCount,
        x.PublishedDate.ToString("yyy-MM-dd")));
    }

    }    
}