using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PruebaIngenieria.Models;

namespace PruebaIngenieria;

public class LibreriaContext : DbContext{

    [Key]
    public DbSet<Autor> Autores {get; set;}

    [Required]
    public DbSet<Libro> Libros {get; set;}
    public LibreriaContext(DbContextOptions<LibreriaContext> options): base(options){}
}