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
    
    public partial class Sam3_DetalleFolioPickingTicket
    {
        public int DetalleFolioPickingTicketID { get; set; }
        public int FolioPickingTicketID { get; set; }
        public Nullable<int> OrdenTrabajoMaterialID { get; set; }
        public int DespachoID { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> UsuarioModificacion { get; set; }
        public bool Activo { get; set; }
    
        public virtual Sam3_Despacho Sam3_Despacho { get; set; }
        public virtual Sam3_FolioPickingTicket Sam3_FolioPickingTicket { get; set; }
    }
}