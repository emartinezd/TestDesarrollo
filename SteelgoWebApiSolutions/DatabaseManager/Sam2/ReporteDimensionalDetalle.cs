//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManager.Sam2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReporteDimensionalDetalle
    {
        public int ReporteDimensionalDetalleID { get; set; }
        public int ReporteDimensionalID { get; set; }
        public int WorkstatusSpoolID { get; set; }
        public Nullable<int> Hoja { get; set; }
        public Nullable<System.DateTime> FechaLiberacion { get; set; }
        public bool Aprobado { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.Guid> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public byte[] VersionRegistro { get; set; }
        public Nullable<int> TallerID { get; set; }
        public Nullable<int> InspectorID { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
        public virtual ReporteDimensional ReporteDimensional { get; set; }
        public virtual Taller Taller { get; set; }
        public virtual WorkstatusSpool WorkstatusSpool { get; set; }
    }
}
