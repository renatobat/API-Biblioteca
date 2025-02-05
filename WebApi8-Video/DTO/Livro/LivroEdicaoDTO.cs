using WebApi8_Video.DTO.Vinculo;
using WebApi8_Video.Models;

namespace WebApi8_Video.DTO.Livro
{
    public class LivroEdicaoDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDTO Autor { get; set; }
    }
}
