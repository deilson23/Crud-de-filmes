using System.ComponentModel.DataAnnotations;

namespace ApiCrudFilmes.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "O tamanho maximo do texto é de 60 caracters")]
        public string Titulo { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "O tamanho maximo do texto é de 60 caracters")]
        public string Autor { get; set; }
        [StringLength(60, ErrorMessage ="O tamanho maximo do texto é de 60 caracters")]
        [Required]
        public string Idioma { get; set; }
        [Range(1,400, ErrorMessage ="O tempo de duracao maximo é de 400 minutos")]
        [Required]
        public int Duracao { get; set; }
        [Range(0.1,10.0, ErrorMessage ="O tamanho da avaliação é de 0 a 10")]
        public float Avaliacao { get; set; }


    }
}
