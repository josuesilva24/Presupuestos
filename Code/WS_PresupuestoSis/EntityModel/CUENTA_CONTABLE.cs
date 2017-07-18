//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cuenta_Contable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuenta_Contable()
        {
            this.Cargas_Sociales = new HashSet<Cargas_Sociales>();
            this.Ingresos = new HashSet<Ingresos>();
        }
    
        public int Id { get; set; }
        public string Cuenta_Contable1 { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> TipoCuenta { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual Cuenta_Contable Cuenta_Contable11 { get; set; }
        public virtual Cuenta_Contable Cuenta_Contable2 { get; set; }
        public virtual Tipo_CuentaContable Tipo_CuentaContable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargas_Sociales> Cargas_Sociales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingresos> Ingresos { get; set; }
    }
}
