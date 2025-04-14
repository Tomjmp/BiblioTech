public abstract class Usuario
{
    public string Nombre { get; set; }
    public string ID { get; set; }

    public Usuario(string nombre, string id)
    {
        Nombre = nombre;
        ID = id;
    }

    public abstract void MostrarAcciones();
}

public class Lector : Usuario
{
    public Lector(string nombre, string id) : base(nombre, id) { }

    public override void MostrarAcciones()
    {
        Console.WriteLine($"[Lector] {Nombre} puede consultar y pedir prestados libros.");
    }
}

public class Administrador : Usuario
{
    public Administrador(string nombre, string id) : base(nombre, id) { }

    public override void MostrarAcciones()
    {
        Console.WriteLine($"[Admin] {Nombre} puede agregar, eliminar y modificar libros.");
    }
}