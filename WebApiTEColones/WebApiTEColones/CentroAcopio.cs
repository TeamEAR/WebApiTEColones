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
    
    public partial class CentroAcopio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CentroAcopio()
        {
            this.EncargadoCentroAcopios = new HashSet<EncargadoCentroAcopio>();
        }
    
        public int IdCentroAcopio { get; set; }
        public string Ubicacion { get; set; }
        public string Identificador { get; set; }
    
        public virtual SedeXTEC SedeXTEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncargadoCentroAcopio> EncargadoCentroAcopios { get; set; }
    }
}
