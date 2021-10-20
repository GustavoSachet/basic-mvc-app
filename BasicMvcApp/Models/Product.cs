using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicAppMvc.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Imagem")]
        public string Image { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Preço")]
        public decimal Price { get; set; }

        public DateTime CreationDate { get; set; }

        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        public Supplier Supplier { get; set; }
    }
}