using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestPage.Models
{
    public class FreteModels
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Endereço de Origem:")]
        public string EndOrigem { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Endereço de Destino:")]
        public string EndDestino { get; set; }
    }
}