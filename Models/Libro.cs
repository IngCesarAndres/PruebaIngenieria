using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PruebaIngenieria.Models;

public class Libro
{
    [Key]
    public Guid LibroId {get; set;}

    [ForeignKey("AutorId")]
    public Guid AutorId {get; set;}
    
    [Required]
    [MaxLength(100)]
    public string Nombre {get; set;}
    
    [Required]
     [MaxLength(100)]
    public string Editorial {get; set;}
    
     [MaxLength(500)]
    public string Descripcion {get; set;}
}