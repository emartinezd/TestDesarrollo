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
    
    public partial class Sam3_FolioCuantificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sam3_FolioCuantificacion()
        {
            this.Sam3_Bulto = new HashSet<Sam3_Bulto>();
            this.Sam3_Rel_FolioCuantificacion_ItemCode = new HashSet<Sam3_Rel_FolioCuantificacion_ItemCode>();
            this.Sam3_Rel_Incidencia_FolioCuantificacion = new HashSet<Sam3_Rel_Incidencia_FolioCuantificacion>();
            this.Sam3_Recepcion = new HashSet<Sam3_Recepcion>();
        }
    
        public int FolioCuantificacionID { get; set; }
        public int FolioAvisoEntradaID { get; set; }
        public int ProyectoID { get; set; }
        public string PackingList { get; set; }
        public int TipoUsoID { get; set; }
        public string Estatus { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> UsuarioModificacion { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> TipoMaterialID { get; set; }
        public Nullable<int> Consecutivo { get; set; }
        public Nullable<int> Rel_Proyecto_Entidad_Configuracion_ID { get; set; }
        public Nullable<int> ConsecutivoConfiguracion { get; set; }
        public string Factura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sam3_Bulto> Sam3_Bulto { get; set; }
        public virtual Sam3_FolioAvisoEntrada Sam3_FolioAvisoEntrada { get; set; }
        public virtual Sam3_Proyecto Sam3_Proyecto { get; set; }
        public virtual Sam3_TipoMaterial Sam3_TipoMaterial { get; set; }
        public virtual Sam3_TipoUso Sam3_TipoUso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sam3_Rel_FolioCuantificacion_ItemCode> Sam3_Rel_FolioCuantificacion_ItemCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sam3_Rel_Incidencia_FolioCuantificacion> Sam3_Rel_Incidencia_FolioCuantificacion { get; set; }
        public virtual Sam3_Rel_Proyecto_Entidad_Configuracion Sam3_Rel_Proyecto_Entidad_Configuracion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sam3_Recepcion> Sam3_Recepcion { get; set; }
    }
}
