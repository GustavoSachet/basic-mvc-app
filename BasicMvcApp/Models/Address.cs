using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicAppMvc.Models
{
    public class Address : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} deve ter {1} caracteres", MinimumLength = 8)]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Estado")]
        public string State { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Cidade")]
        public string City { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Bairro")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Rua")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Número")]
        public string Number { get; set; }

        [DisplayName("Complemento")]
        public string Complement { get; set; }
    }
}