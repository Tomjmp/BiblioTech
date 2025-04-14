public class Prestamo
{
    public Libro LibroPrestado { get; set; }
    public Usuario UsuarioPrestamo { get; set; }
    public DateTime Fecha { get; set; }

    public Prestamo(Libro libro, Usuario usuario)
    {
        LibroPrestado = libro;
        UsuarioPrestamo = usuario;
        Fecha = DateTime.Now;
    }
}