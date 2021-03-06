//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.PedidosDetalle = new HashSet<PedidosDetalle>();
        }
    
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public string CantXUnidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int UnidadesEnExistencia { get; set; }
        public int UnidadesEnPedido { get; set; }
        public string Foto { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidosDetalle> PedidosDetalle { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
