using PruebaIngenieria;
using PruebaIngenieria.Models;

public class LibroService: ILibroService
{
    LibreriaContext _libreria;

    public LibroService(LibreriaContext auxLibreria)
    {
        _libreria = auxLibreria;
    }

    public IEnumerable<Libro> GetLibro()
    {
        return _libreria.Libros;
    }

    public async Task SaveLibro(Libro libro)
    {
        _libreria.Add(libro);
        await _libreria.SaveChangesAsync();
    }

    public async Task UpdateLibro(Guid id, Libro libro)
    {
        var auxLibro = _libreria.Libros.Find(id);

        if(auxLibro != null)
        {
            auxLibro.Nombre = libro.Nombre;
            auxLibro.Editorial = libro.Editorial;
            auxLibro.Descripcion = libro.Descripcion;
        }

        await _libreria.SaveChangesAsync();
    }


    public async Task DeleteLibro(Guid id)
    {
        var auxLibro = _libreria.Libros.Find(id);

        if(auxLibro != null)
        {
            _libreria.Remove(auxLibro);
            await _libreria.SaveChangesAsync();
        }
    }
}

public interface ILibroService
{
    IEnumerable<Libro> GetLibro();
    Task SaveLibro(Libro libro);
    Task UpdateLibro(Guid id, Libro libro);
    Task DeleteLibro(Guid id);
}