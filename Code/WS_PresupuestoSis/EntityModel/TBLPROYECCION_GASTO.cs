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
    
    public partial class TBLPROYECCION_GASTO
    {
        public int LNGIDPROYECCIONGASTO { get; set; }
        public Nullable<int> LNGIDCUENTACONTABLE { get; set; }
        public Nullable<int> LNGIDCENTROCOSTO { get; set; }
        public Nullable<int> LNGIDMONEDA { get; set; }
        public string STRENERO { get; set; }
        public string STRFEBRERO { get; set; }
        public string STRMARZO { get; set; }
        public string STRABRIL { get; set; }
        public string STRMAYO { get; set; }
        public string STRJUNIO { get; set; }
        public string STRJULIO { get; set; }
        public string STRAGOSTO { get; set; }
        public string STRSEPTIEMBRE { get; set; }
        public string STROCTUBRE { get; set; }
        public string STRNOVIEMBRE { get; set; }
        public string STRDICIEMBRE { get; set; }
        public Nullable<System.DateTime> DTRFECHA { get; set; }
        public string STRMONTO_COLONES { get; set; }
        public string STRMONTO_DOLARES { get; set; }
        public string STRPRESUPUESTO { get; set; }
        public Nullable<int> LNGIDTIPOPRESUPUESTO { get; set; }
        public string STRDETALLE { get; set; }
        public Nullable<int> LNGIDPROYECTO { get; set; }
        public Nullable<int> LNGIDUSUARIO { get; set; }
        public Nullable<int> LNGIDTIPOPROYECCION { get; set; }
        public Nullable<int> LNGIDTIPOGASTO { get; set; }
        public string STRANNO { get; set; }
    
        public virtual TBLCENTROCOSTO TBLCENTROCOSTO { get; set; }
        public virtual TBLCUENTACONTABLE TBLCUENTACONTABLE { get; set; }
        public virtual TBLMONEDA TBLMONEDA { get; set; }
        public virtual TBLTIPOPRESUPUESTO TBLTIPOPRESUPUESTO { get; set; }
    }
}
