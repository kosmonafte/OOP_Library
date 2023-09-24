using Library;
internal class Program {
    private static void Main(string[] args) {
        Libr library = new Libr();
        library.AddBook(new Book("Джек Лондон", "Моряк в седле"));
        library.AddBook(new Book("Лев Толстой", "Война и мир"));
        library.AddBook(new Book("Федор Достоевский", "Преступление и наказание"));

        Reader reader = new Reader("Ivanov");
        reader.setCard(library.CreateCard(reader.getName()));

        Console.WriteLine(library.ToString());
        Console.WriteLine(reader.ToString());

        library.IssueABook("Джек Лондон", "Моряк в седле", reader);
        Console.WriteLine("-----------------------");
        Console.WriteLine(library.ToString());
        Console.WriteLine(reader.ToString());

        library.IssueABook("Федор Достоевский", "Преступление и наказание", reader);
        Console.WriteLine("-----------------------");
        Console.WriteLine(library.ToString());
        Console.WriteLine(reader.ToString());

        library.retBook("Джек Лондон", "Моряк в седле", reader);
        Console.WriteLine("-----------------------");
        Console.WriteLine(library.ToString());
        Console.WriteLine(reader.ToString());
    }
}