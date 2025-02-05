using WebApi8_Video.DTO.Autor;
using WebApi8_Video.DTO.Livro;
using WebApi8_Video.Models;

namespace WebApi8_Video.Services.Livro
{
    public interface ILivroInterface
    {
        Task<ResponseModel<List<LivroModel>>> ListarLivros();
        Task<ResponseModel<LivroModel>> BuscarLivroPorId(int idLivro);
        Task<ResponseModel<List<LivroModel>>> BuscarLivroPorIdAutor(int idAutor);
        Task<ResponseModel<List<LivroModel>>> CriarLivro(LivroCriacaoDTO livroCriacaoDTO);
        Task<ResponseModel<List<LivroModel>>> EditarLivro(LivroEdicaoDTO livroEdicaoDTO);
        Task<ResponseModel<List<LivroModel>>> ExcluirLivro(int idLivro);
    }
}
