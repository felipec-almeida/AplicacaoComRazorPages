using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Models
{
    public class Filme
    {

        public int Id { get; set; }

        [Display(Name = "Título do Filme")]
        [Required(ErrorMessage = "É necessário digitar o título do filme.")]
        [MinLength(4, ErrorMessage = "O título do Filme é muito pequeno, tente novamente.")]
        [MaxLength(100, ErrorMessage = "O título do Filme é muito grande, tente novamente.")]
        public string Titulo { get; set; } = string.Empty;

        
        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "É necessário especificar o gênero do filme.")]
        [MinLength(4, ErrorMessage = "O gênero do Filme é muito pequeno, tente novamente.")]
        [MaxLength(30, ErrorMessage = "O gênero do Filme é muito grande, tente novamente.")]
        public string Genero { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "É necessário digitar o preço do filme.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Avaliação Crítica")]
        [Required(ErrorMessage = "É necessário digitar a avaliação crítica do filme")]
        [Range(0, 100)]
        public int AvaliacaoCritica { get; set; } = 0;

        [Display(Name = "Avaliação do Público")]
        [Required(ErrorMessage = "É necessário digitar a avaliação do público ao filme")]
        [Range(0, 100)]
        public int AvaliacaoPublico { get; set; } = 0;

        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "É necessário colocar a data de lançamento do filme.")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

    }
}
