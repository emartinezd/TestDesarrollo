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
    
    public partial class Sam3_Rel_Documento_Entidad
    {
        public int TipoDocumentoID { get; set; }
        public Nullable<int> EntidadID { get; set; }
        public Nullable<int> RepositorioID { get; set; }
        public Nullable<int> UsuarioID { get; set; }
        public string Identificador { get; set; }
        public Nullable<System.DateTime> FechaSubida { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual Sam3_Entidad Sam3_Entidad { get; set; }
        public virtual Sam3_Repositorio Sam3_Repositorio { get; set; }
        public virtual Sam3_TipoDocumento Sam3_TipoDocumento { get; set; }
    }
}