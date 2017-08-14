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
    
    public partial class UbicacionFisica
    {
        public UbicacionFisica()
        {
            this.NumeroUnicoCorte = new HashSet<NumeroUnicoCorte>();
        }
    
        public int UbicacionFisicaID { get; set; }
        public int PatioID { get; set; }
        public string Nombre { get; set; }
        public bool EsAreaCorte { get; set; }
        public Nullable<System.Guid> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public byte[] VersionRegistro { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
        public virtual ICollection<NumeroUnicoCorte> NumeroUnicoCorte { get; set; }
        public virtual Patio Patio { get; set; }
    }
}