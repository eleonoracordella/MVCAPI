using System.ComponentModel.DataAnnotations;

namespace MVCAPI.Models.Entites
{
    public class Facolta
    {
        [Key]
        public Guid IdFacolta { get; set; }
        public string? descrizione { get; set; }

    }

}
