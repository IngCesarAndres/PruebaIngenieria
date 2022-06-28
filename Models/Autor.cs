using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PruebaIngenieria.Models;

public class Autor
{
    [Key]
    public Guid AutorId {get; set;}
    
    [Required]
     [MaxLength(50)]
    public string Nombre {get; set;}
    
    [Required]
     [MaxLength(50)]
    public string Apellido {get; set;}

}