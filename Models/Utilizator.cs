using System.ComponentModel.DataAnnotations;

namespace licenta.Models
{
    public class Utilizator
    {
        [Key]
        public Guid Id { get; set; }         
        public string Nume { get; set; }    
        public string Email { get; set; }   
    }
}
