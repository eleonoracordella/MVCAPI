using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCAPI.Models.Entites
{
    public class Studente
    {
        [Key]
        public Guid Id { get; set; }
        public string? cognome { get; set; }
        public string? nome { get; set; }

        // In questo indico chiave esterna
        public Guid IdFacolta { get; set; }
        [ForeignKey("IdFacolta")]

        // Campo per vederlo nella View
        [ValidateNever]
        public Facolta Facolta { get; set; }
    }
}
