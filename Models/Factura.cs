namespace FACTURA_APP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            Detalle_Factura = new HashSet<Detalle_Factura>();
        }

        [Key]
        public int cod_fac { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(8)]
        public string NumeroFactura { get; set; }

        public DateTime Fecha { get; set; }

        public decimal BaseIVA0 { get; set; }

        public decimal BaseIVA12 { get; set; }

        public decimal IVA { get; set; }

        public decimal Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Factura> Detalle_Factura { get; set; }
    }
}
