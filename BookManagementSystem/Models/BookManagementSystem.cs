namespace BookManagementSystem.Models{
    /// <summary>
    /// Manages the collection of books in the system
    /// Contains methods to add, view, and remove books from the book dictionary
    /// </summary>
    public class BookManager{
        // This is a dictionary because it looks up items easier with ids
        private Dictionary<int, Book> Books{get; set;}
        public BookManager(){
            Books = new Dictionary<int, Book>{
                // for testing purposes only
               {1, new Book{Title = "the Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Id = 1}},
               {2, new Book{Title = "TLDR", Author = "F. Scott Fitzgerald", Genre = "Fiction", Id = 2}},
               {3, new Book{Title = "1984", Author = "F. Scott Fitzgerald", Genre = "Fiction", Id = 3}},
            };
        }
        /// <summary>
        /// addes a new book to the system from user input
        /// </summary>
        public void AddBook(){
            Book newBook = new Book();
            Console.WriteLine("Enter the title of the book: ");
            newBook.Title = Console.ReadLine();

            Console.WriteLine("Enter the author of the book: ");
            newBook.Author = Console.ReadLine();

            Console.WriteLine("Enter the genre of the book: ");
            newBook.Genre = Console.ReadLine();

            // continues until unique ID is entered
            while (true){
            Console.WriteLine("Enter the ID of the book: ");
            int givenId = int.Parse(Console.ReadLine());
            if (Books.ContainsKey(givenId)){
                Console.WriteLine("ID already exists.");
                continue;
            }
            else{
                newBook.Id = givenId;
                Books.Add(givenId, newBook);
                break;
            }
            }

        }
        /// <summary>
        /// Gets all books in the system
        /// </summary>
        public void GetBooks(){
            foreach (Book book in Books.Values){
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"ID: {book.Id}");
                Console.WriteLine("--------------------------");
            }
        }
        /// <summary>
        /// Gets a book by its ID
        /// </summary>
        public void GetBookById(){
            Console.WriteLine("Enter book ID search");
            int id = int.Parse(Console.ReadLine());
            if (Books.ContainsKey(id)){
                Book book = Books[id];
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"ID: {book.Id}");
                Console.WriteLine("--------------------------");
            }
            else{
                Console.WriteLine("Book not found.");
                Console.WriteLine("--------------------------");
            }
        }
        /// <summary>
        /// Removes a book by its ID after confirmation
        /// </summary>
        public void RemoveBookById(){
            Console.WriteLine("Enter book ID to remove");
            int id = int.Parse(Console.ReadLine());
            if (Books.ContainsKey(id)){
                Book book = Books[id];
                
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Confirm remove book? y/n");

                string confirmation = Console.ReadLine().ToLower();
                if (confirmation == "Y"){
                    Books.Remove(id);
                    Console.WriteLine("Book removed successfully");
                    Console.WriteLine("--------------------------");
                }
                else{
                    Console.WriteLine("Book removal canceled");
                    Console.WriteLine("--------------------------");
                }
            }
            else{
                Console.WriteLine("Book not found.");
                Console.WriteLine("--------------------------");
            }
        }
    }
}