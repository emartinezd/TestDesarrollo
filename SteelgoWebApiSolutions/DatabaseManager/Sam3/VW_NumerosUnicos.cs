//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManager.Sam3
{
    using System;
    using System.Collections.Generic;
    
    public partial class VW_NumerosUnicos
    {
        public int NumeroUnicoID { get; set; }
        public string NumeroUnico { get; set; }
        public string Proyecto { get; set; }
        public int ItemCodeID { get; set; }
        public string ItemCodeCodigo { get; set; }
        public int ItemCodeSteelgoID { get; set; }
        public string ItemCodeSteelgoCodigo { get; set; }
        public int FolioCuantificacionID { get; set; }
        public Nullable<int> FolioAvisoLlegadaID { get; set; }
        public int FolioAvisoEntradaID { get; set; }
        public string Cliente { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public int Patio { get; set; }
    }
}
