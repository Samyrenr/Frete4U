//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestPage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa_Veiculo_Vinculo
    {
        public int IDVinculo { get; set; }
        public int IDPessoa { get; set; }
        public int IDVeiculo { get; set; }
        public Nullable<bool> Inativo { get; set; }
    
        public virtual Pessoa Pessoa { get; set; }
        public virtual Veiculo Veiculo { get; set; }
    }
}
