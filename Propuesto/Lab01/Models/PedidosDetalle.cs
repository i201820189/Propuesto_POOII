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
    
    public partial class PedidosDetalle
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short Cantidad { get; set; }
        public double Descuento { get; set; }
        public int IdDetalle { get; set; }
    
        public virtual Productos Productos { get; set; }
        public virtual PedidosCabecera PedidosCabecera { get; set; }
    }
}
