using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevIOApi.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Descricao { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public string NomeFornecedor { get; set; }
         
    }
}
