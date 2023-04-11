﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Shared.Repositories
{
    [Table("SeguimientoPAMEC", Schema = "pamec")]
    public partial class SeguimientoPAMEC
    {
        [Key]
        public int id { get; set; }
        public int idRegistro { get; set; }
        public int idAccionATomar { get; set; }
        public int idTipoVisita { get; set; }
        public int idResultadoEjecucion { get; set; }
        [Required]
        [StringLength(4000)]
        public string obsResultadoEjecucion { get; set; }
        public bool adelantoAccionesAdminInspVigCon { get; set; }
        public int idDetalleAccionAdmin { get; set; }
        [Required]
        [StringLength(4000)]
        public string causasOrigenActAdmin { get; set; }
        public int realizoReportesPAMEC { get; set; }
        [Required]
        [StringLength(4000)]
        public string obsRealizoReportesPAMEC { get; set; }
        [Required]
        [StringLength(4000)]
        public string motivoNoEnvioReporte { get; set; }
        [Column(TypeName = "date")]
        public DateTime fechaCorte { get; set; }
        [Column(TypeName = "date")]
        public DateTime fechaReporte { get; set; }
        public int cargo { get; set; }
        public int idResponsableSeguimiento { get; set; }
        [Required]
        [StringLength(15)]
        public string celular { get; set; }
        [Required]
        [StringLength(4000)]
        public string observaciones { get; set; }
        [Column(TypeName = "date")]
        public DateTime fechaCreacion { get; set; }
        public Guid? idVerificadorU { get; set; }

        [ForeignKey(nameof(idAccionATomar))]
        [InverseProperty(nameof(Constante.SeguimientoPAMECidAccionATomarNavigation))]
        public virtual Constante idAccionATomarNavigation { get; set; }
        [ForeignKey(nameof(idDetalleAccionAdmin))]
        [InverseProperty(nameof(Constante.SeguimientoPAMECidDetalleAccionAdminNavigation))]
        public virtual Constante idDetalleAccionAdminNavigation { get; set; }
        [ForeignKey(nameof(idRegistro))]
        [InverseProperty(nameof(Registro.SeguimientoPAMEC))]
        public virtual Registro idRegistroNavigation { get; set; }
        [ForeignKey(nameof(idResponsableSeguimiento))]
        [InverseProperty(nameof(Usuario_Cargo.SeguimientoPAMEC))]
        public virtual Usuario_Cargo idResponsableSeguimientoNavigation { get; set; }
        [ForeignKey(nameof(idResultadoEjecucion))]
        [InverseProperty(nameof(Constante.SeguimientoPAMECidResultadoEjecucionNavigation))]
        public virtual Constante idResultadoEjecucionNavigation { get; set; }
        [ForeignKey(nameof(idTipoVisita))]
        [InverseProperty(nameof(Constante.SeguimientoPAMECidTipoVisitaNavigation))]
        public virtual Constante idTipoVisitaNavigation { get; set; }
        [ForeignKey(nameof(idVerificadorU))]
        [InverseProperty(nameof(Usuario.SeguimientoPAMEC))]
        public virtual Usuario idVerificadorUNavigation { get; set; }
        [ForeignKey(nameof(realizoReportesPAMEC))]
        [InverseProperty(nameof(Constante.SeguimientoPAMECrealizoReportesPAMECNavigation))]
        public virtual Constante realizoReportesPAMECNavigation { get; set; }
    }
}