//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLCENTROCOSTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCENTROCOSTO()
        {
            this.TBLPRESUPUESTO_PROYECCION_SALARIO = new HashSet<TBLPRESUPUESTO_PROYECCION_SALARIO>();
            this.TBLPRESUPUESTOPROYECCIONINGRESO = new HashSet<TBLPRESUPUESTOPROYECCIONINGRESO>();
            this.TBLPROYECCION_GASTO = new HashSet<TBLPROYECCION_GASTO>();
        }
    
        public int LNGIDCENTROCOSTO { get; set; }
        public string STRCODIGO { get; set; }
        public string STRDESCRIPCION { get; set; }
        public string STRACTIVO { get; set; }
        public Nullable<System.DateTime> DTMFECHA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPRESUPUESTO_PROYECCION_SALARIO> TBLPRESUPUESTO_PROYECCION_SALARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPRESUPUESTOPROYECCIONINGRESO> TBLPRESUPUESTOPROYECCIONINGRESO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPROYECCION_GASTO> TBLPROYECCION_GASTO { get; set; }
    }
}
