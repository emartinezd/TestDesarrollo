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
    
    public partial class MaterialSpoolHistorico
    {
        public int MaterialSpoolHistoricoID { get; set; }
        public int SpoolHistoricoID { get; set; }
        public int MaterialSpoolID { get; set; }
        public int SpoolID { get; set; }
        public int ItemCodeID { get; set; }
        public decimal Diametro1 { get; set; }
        public decimal Diametro2 { get; set; }
        public string Etiqueta { get; set; }
        public int Cantidad { get; set; }
        public Nullable<decimal> Peso { get; set; }
        public Nullable<decimal> Area { get; set; }
        public string Especificacion { get; set; }
        public string Grupo { get; set; }
        public Nullable<System.Guid> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public byte[] VersionRegistro { get; set; }
        public string SpoolNombre { get; set; }
        public string ItemCodeDescripcionEspanol { get; set; }
        public string ItemCodeDescripcionIngles { get; set; }
        public string ItemCodeCodigo { get; set; }
    
        public virtual SpoolHistorico SpoolHistorico { get; set; }
    }
}