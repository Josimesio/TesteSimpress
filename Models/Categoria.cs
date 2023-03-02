using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTesteEntrevista.Models
{

    [Table("tblCategoriaProduto")]
    public class Categoria
    {
        [Display(Name ="Codigo")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descricao")]
        public string Descricao  { get; set; }
        [Display(Name = "Ativo")]
        public string Ativo { get; set; }       
    }
}
