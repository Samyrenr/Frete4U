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
    
    public partial class Veiculo
    {
        public Veiculo()
        {
            this.Pessoa_Veiculo_Vinculo = new HashSet<Pessoa_Veiculo_Vinculo>();
        }
    
        public int IDVeiculo { get; set; }
        public int IDFabricante { get; set; }
        public Nullable<int> IDTipoCombustivel { get; set; }
        public Nullable<int> IDTipoVeiculo { get; set; }
        public Nullable<System.DateTime> Ano { get; set; }
    
        public virtual Fabricante_Veiculo Fabricante_Veiculo { get; set; }
        public virtual ICollection<Pessoa_Veiculo_Vinculo> Pessoa_Veiculo_Vinculo { get; set; }
        public virtual Tipo_Combustivel Tipo_Combustivel { get; set; }
        public virtual Tipo_Veiculo Tipo_Veiculo { get; set; }
    }
}