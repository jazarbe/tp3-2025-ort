namespace TP3_Arias.Models;

public class disco
{
    public int id { get; private set; }
    public string nombre { get; private set; }
    public string artista { get; private set; }
    public string productor { get; private set; }
    public string genero { get; private set; }
    public string foto { get; private set; }
    public List<string> canciones { get; private set; }

    public disco(int id, string nombre, string artista, string productor, string genero, string foto, List<string> canciones)
    {
        this.id = id;
        this.nombre = nombre;
        this.artista = artista;
        this.productor = productor;
        this.genero = genero;
        this.foto = foto;
        this.canciones = canciones;
    }
}