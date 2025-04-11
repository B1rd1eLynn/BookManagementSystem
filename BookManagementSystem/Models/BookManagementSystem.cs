namespace BookManagementSystem.Models{
    public class BookManager{
        // This is a dictionary because it looks up items easier with ids
        private Dictionary<int, Book> Books{get; set;}
        public BookManager(){
            Books = new Dictionary<int, Book>{
                // for testing purposes only
               {1, new Book{Title = "the Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Historical Fiction", Id = 1}};
            };
        }

        public void AddBook(){
            Book newBook = new Book();
            Console.WriteLine("Enter the title of the book: ");
            newBook.Title = Console.ReadLine();

            Console.WriteLine("Enter the author of the book: ");
            newBook.Author = Console.ReadLine();

            Console.WriteLine("Enter the genre of the book: ");
            newBook.Genre = Console.ReadLine();

            Console.WriteLine("Enter the ID of the book: ");
            newBook.Id = int.Parse(Console.ReadLine());

            Books.Add(newBook.Id, newBook);
        }

        public void GetBooks(){
            foreach (Book book in Books.Values){
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"ID: {book.Id}");
            }
        }
    }
}