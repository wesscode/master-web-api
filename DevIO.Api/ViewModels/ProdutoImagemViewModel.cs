using System.ComponentModel.DataAnnotations;
using DevIO.Api.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.ViewModels
{
    // Binder personalizado para envio de IFormFile e ViewModel dentro de um FormData compatível com .NET Core 3.1 ou superior (system.text.json)
    [ModelBinder(BinderType = typeof(ProdutoModelBinder))]
    public class ProdutoImagemViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracters", MinimumLength = 2)]
        public string Descricao { get; set; }
        public IFormFile ImagemUpload { get; set; } //classe do aspnet para realizar Stream de dados, vai mandar o arquivo em partes.
        public string Imagem { get; set; } //Nome Imagem

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public string NomeFornecedor { get; set; }

    }
}