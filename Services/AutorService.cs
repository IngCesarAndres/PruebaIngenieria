using PruebaIngenieria;
using PruebaIngenieria.Models;

public class AutorService: IAutorService
{
    LibreriaContext _libreria;

    public AutorService(LibreriaContext auxLibreria)
    {
        _libreria = auxLibreria;
    }

    public IEnumerable<Autor> GetAutor()
    {
        return _libreria.Autores;
    }

    public async Task SaveAutor(Autor autor)
    {
        _libreria.Add(autor);
        await _libreria.SaveChangesAsync();
    }

    public async Task UpdateAutor(Guid id, Autor autor)
    {
        var auxAutor = _libreria.Autores.Find(id);

        if(auxAutor != null)
        {
            auxAutor.Nombre = autor.Nombre;
            auxAutor.Apellido = autor.Apellido;
        }

        await _libreria.SaveChangesAsync();
    }


    public async Task DeleteAutor(Guid id)
    {
        var auxAutor = _libreria.Autores.Find(id);

        if(auxAutor != null)
        {
            _libreria.Remove(auxAutor);
            await _libreria.SaveChangesAsync();
        }
    }
}

public interface IAutorService
{
    IEnumerable<Autor> GetAutor();
    Task SaveAutor(Autor autor);
    Task UpdateAutor(Guid id, Autor autor);
    Task DeleteAutor(Guid id);
}