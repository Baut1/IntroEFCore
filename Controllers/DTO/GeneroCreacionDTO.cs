using System.ComponentModel.DataAnnotations;

namespace IntroEFCore.Controllers.DTO
{
    public class GeneroCreacionDTO
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }
}
