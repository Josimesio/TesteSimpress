using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTesteEntrevista.Models
{

    [Table("tblProduto")]
    public class Produto
    {

        [Display(Name ="Código do Produto")]
        public int Id { get; set; }
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        [Display(Name = "Descrição do Produto")]
        public string Descricao  { get; set; }
        [Display(Name = "Ativo")]
        public string Ativo { get; set; }
        [Display(Name = "Perecivel")]
        public string Perecivel { get; set; }
        [Display(Name = "CategoriaID")]
        public string CategoriaID { get; set; }


    }
}
