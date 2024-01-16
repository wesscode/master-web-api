using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid FornecedorId { get; set; }
         [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters.", MinimumLength = 2)]
        public string Logradouro { get; set; }
         [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters.", MinimumLength = 1)]
        public string Numero { get; set; }
        public string Complemento { get; set; }

         [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter {1} caracters.", MinimumLength = 8)]
        public string Cep { get; set; }
         [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters.", MinimumLength = 2)]
        public string Bairro { get; set; }
        public string Cidade { get; set; }
         [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters.", MinimumLength = 2)]
        public string Estado { get; set; }
    }
}