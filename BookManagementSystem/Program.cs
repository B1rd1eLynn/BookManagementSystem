using BookManagementSystem.Models;
 BookManager manager = new BookManager();

while (true){
    Console.WriteLine("--------------------------");
    Console.WriteLine("Welcome to the Book Management System");
    Console.WriteLine("1. Add a new book");
    Console.WriteLine("2. View all books");
    Console.WriteLine("3. View a book by ID");
    Console.WriteLine("4. Remove a book by ID");
    Console.WriteLine("5. Exit");
    Console.WriteLine("--------------------------");

    Console.Write("Please select an option: ");
    string input = Console.ReadLine();
    switch (input){
        case "1":
            manager.AddBook();
            break;
        case "2":
            manager.GetBooks();
            break;
        case "3":
            manager.GetBookById();
            break;
        case "4":
            manager.RemoveBookById();
            break;
        case "5":
            Console.WriteLine("Exiting the system. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
 