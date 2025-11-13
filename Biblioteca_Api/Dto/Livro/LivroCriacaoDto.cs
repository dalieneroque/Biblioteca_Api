using Biblioteca_Api.Models;
using System.Text.Json.Serialization;

namespace Biblioteca_Api.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }     
        public AutorModel Autor { get; set; }
    }
}
