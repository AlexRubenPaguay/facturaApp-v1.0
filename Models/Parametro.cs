namespace FACTURA_APP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parametro")]
    public partial class Parametro
    {
        [Key]
        public int cod_parametro { get; set; }

        [StringLength(5)]
        public string codigo { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        [StringLength(50)]
        public string valor { get; set; }
    }
}
