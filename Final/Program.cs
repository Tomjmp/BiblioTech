class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblio = new Biblioteca();

        // Crear libros
        var libro1 = new LibroFisico("Cien Años de Soledad", "García Márquez", "123-A", 12);
        var libro2 = new LibroDigital("Clean Code", "Robert C. Martin", "456-B", 5.8);

        // Crear usuarios
        var admin = new Administrador("Tomás Admin", "A1");
        var lector = new Lector("Ana Lectora", "L1");

        // Agregar libros a la biblioteca
        biblio.AgregarLibro(libro1);
        biblio.AgregarLibro(libro2);

        // Mostrar libros disponibles
        Console.WriteLine("\n📚 Libros disponibles:");
        biblio.MostrarLibros();

        // Mostrar acciones
        admin.MostrarAcciones();
        lector.MostrarAcciones();

        // Préstamo
        Console.WriteLine("\n🔄 Préstamo de libro:");
        biblio.PrestarLibro("123-A", lector);

        // Mostrar libros luego del préstamo
        Console.WriteLine("\n📚 Libros disponibles después del préstamo:");
        biblio.MostrarLibros();

        // Devolver libro
        Console.WriteLine("\n🔁 Devolución de libro:");
        biblio.DevolverLibro("123-A");

        // Mostrar libros luego de la devolución
        Console.WriteLine("\n📚 Libros disponibles después de la devolución:");
        biblio.MostrarLibros();
    }
}
