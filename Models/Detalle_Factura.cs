namespace FACTURA_TEST1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detalle_Factura
    {
        [Key]
        public int cod_det_fac { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int PorcentajeIVA { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Subtotal { get; set; }

        public int cod_factura { get; set; }

        public int cod_producto { get; set; }

        public virtual Factura Factura { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
