using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MatLanches.Models
{
    [Table("Categorias")]  
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage ="Máximo 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string  CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao{ get; set; }


        public List<Lanche> Lanches { get; set;}
    }
}
