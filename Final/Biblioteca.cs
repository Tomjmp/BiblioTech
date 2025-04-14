public class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private List<Prestamo> prestamos = new List<Prestamo>();

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void MostrarLibros()
    {
        foreach (var libro in libros)
        {
            libro.MostrarInfo();
        }
    }

    public void PrestarLibro(string isbn, Usuario usuario)
    {
        var libro = libros.FirstOrDefault(l => l.ISBN == isbn && l.Disponible);
        if (libro != null)
        {
            libro.Disponible = false;
            prestamos.Add(new Prestamo(libro, usuario));
            Console.WriteLine($"Libro '{libro.Titulo}' prestado a {usuario.Nombre}.");
        }
        else
        {
            Console.WriteLine("Libro no disponible o no encontrado.");
        }
    }

    public void DevolverLibro(string isbn)
    {
        var libro = libros.FirstOrDefault(l => l.ISBN == isbn);
        if (libro != null && !libro.Disponible)
        {
            libro.Disponible = true;
            Console.WriteLine($"Libro '{libro.Titulo}' ha sido devuelto.");
        }
        else
        {
            Console.WriteLine("El libro no está prestado o no existe.");
        }
    }
}