public class LibroDigital : Libro
{
    public double PesoMB { get; set; }

    public LibroDigital(string titulo, string autor, string isbn, double pesoMB)
        : base(titulo, autor, isbn)
    {
        PesoMB = pesoMB;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"[Digital] {Titulo} de {Autor}, ISBN: {ISBN}, Peso: {PesoMB}MB, Disponible: {Disponible}");
    }
}