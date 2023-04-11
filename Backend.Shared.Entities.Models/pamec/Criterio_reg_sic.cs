﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Shared.Repositories
{
    [Table("Criterio_reg_sic", Schema = "pamec")]
    public partial class Criterio_reg_sic
    {
        [Key]
        public int id { get; set; }
        public int? criterioID { get; set; }
        public int? regSicID { get; set; }
        public int? aprobacion { get; set; }

        [ForeignKey(nameof(criterioID))]
        [InverseProperty(nameof(Criterio.Criterio_reg_sic))]
        public virtual Criterio criterio { get; set; }
        [ForeignKey(nameof(regSicID))]
        [InverseProperty(nameof(RegistroSIC.Criterio_reg_sic))]
        public virtual RegistroSIC regSic { get; set; }
    }
}