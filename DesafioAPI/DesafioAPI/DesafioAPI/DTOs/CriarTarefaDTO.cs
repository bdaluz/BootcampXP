using DesafioAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace DesafioAPI.DTOs
{
    public class CriarTarefaDTO
    {
        [Required(ErrorMessage = "O título é obrigatório.")]
        [MaxLength(200)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [MaxLength(2000)]
        public string Descricao { get; set; }
        public DateTime? Data { get; set; }
    }
}
