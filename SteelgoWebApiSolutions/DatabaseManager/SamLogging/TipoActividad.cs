//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManager.SamLogging
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoActividad
    {
        public TipoActividad()
        {
            this.Bitacora = new HashSet<Bitacora>();
        }
    
        public int TipoActividadID { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    
        public virtual ICollection<Bitacora> Bitacora { get; set; }
    }
}