//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiTEColones
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistorialPromocion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistorialPromocion()
        {
            this.CambioMaterialEstudiantes = new HashSet<CambioMaterialEstudiante>();
        }
    
        public int IdHistorialPromocion { get; set; }
        public int IdPromocion { get; set; }
        public int IdAdmi { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public string DetalleModificacion { get; set; }
    
        public virtual Administrador Administrador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CambioMaterialEstudiante> CambioMaterialEstudiantes { get; set; }
        public virtual Promocion Promocion { get; set; }
    }
}
