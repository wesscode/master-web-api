

using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{

    public class FornecedorViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters.", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters.", MinimumLength = 11)]
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public bool Ativo { get; set; }
        public EnderecoViewModel EnderecoViewModel { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}