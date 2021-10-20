using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicAppMvc.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 11)]
        [DisplayName("Documento")]
        public string Document { get; set; }

        [DisplayName("Tipo Fornecedor")]
        public SupplierType Type { get; set; }

        [DisplayName("Endereço")]
        public Address Address { get; set; }

        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}