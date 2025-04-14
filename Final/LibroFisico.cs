public class LibroFisico : Libro
{
    public int Estanteria { get; set; }

    public LibroFisico(string titulo, string autor, string isbn, int estanteria)
        : base(titulo, autor, isbn)
    {
        Estanteria = estanteria;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"[Físico] {Titulo} de {Autor}, ISBN: {ISBN}, Estantería: {Estanteria}, Disponible: {Disponible}");
    }
}