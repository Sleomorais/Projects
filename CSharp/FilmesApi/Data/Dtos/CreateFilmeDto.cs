using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "Titulo do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O Tamanho do gênero não pode conter mais que 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "Duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = " A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
