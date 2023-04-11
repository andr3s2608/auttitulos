﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Shared.Repositories
{
    [Table("Permiso", Schema = "pamec")]
    public partial class Permiso
    {
        [Key]
        public int id { get; set; }
        public bool consultar { get; set; }
        public bool crear { get; set; }
        public bool eliminar { get; set; }
        public bool actualizar { get; set; }

        [ForeignKey(nameof(id))]
        [InverseProperty(nameof(Menu_Cargo.Permiso))]
        public virtual Menu_Cargo idNavigation { get; set; }
    }
}