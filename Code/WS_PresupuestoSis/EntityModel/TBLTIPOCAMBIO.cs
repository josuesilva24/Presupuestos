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
    
    public partial class TBLTIPOCAMBIO
    {
        public int LNGIDTIPOCAMBIO { get; set; }
        public Nullable<int> LNGIDANNO { get; set; }
        public Nullable<int> LNGIDMONEDA { get; set; }
        public Nullable<int> LNGIDTIPOPRESUPUESTO { get; set; }
        public Nullable<double> FLTENERO { get; set; }
        public Nullable<double> FLTFEBRERO { get; set; }
        public Nullable<double> FLTMARZO { get; set; }
        public Nullable<double> FLTABRIL { get; set; }
        public Nullable<double> FLTMAYO { get; set; }
        public Nullable<double> FLTJUNIO { get; set; }
        public Nullable<double> FLTJULIO { get; set; }
        public Nullable<double> FLTAGOSTO { get; set; }
        public Nullable<double> FLTSEPTIEMBRE { get; set; }
        public Nullable<double> FLTOCTUBRE { get; set; }
        public Nullable<double> FLTNOVIEMBRE { get; set; }
        public Nullable<double> FLTDICIEMBRE { get; set; }
        public Nullable<System.DateTime> DTRFECHA { get; set; }
    
        public virtual TBLMONEDA TBLMONEDA { get; set; }
        public virtual TBLTIPOPRESUPUESTO TBLTIPOPRESUPUESTO { get; set; }
    }
}