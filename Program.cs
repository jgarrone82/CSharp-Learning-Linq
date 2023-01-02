using C__Learning_Linq;

LinqQueries queries = new LinqQueries();

// All the books
//queries.printBooks();

//Books after 2000
//queries.BooksAfter2000();

//Books with more than 250 pages and title in Action
//queries.BooksAfterWith250PagesandTitle();

//All the books have status
//Console.WriteLine($"All the books have Status? {queries.AllTheBooksStatus()}");

//If any book was published in 2005
//Console.WriteLine($"Is there any book published in 2005? {queries.AnyBooksPublished2005()}");

//Books Contains the word python
queries.BooksContains();