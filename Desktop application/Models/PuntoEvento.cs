﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CSMaps.Models;

public partial class PuntoEvento
{
    public int IdPunto { get; set; }

    public short IdEvento { get; set; }

    public byte IdEventoTipo { get; set; }

    public DateTime FechaHora { get; set; }

    public string Notas { get; set; }

    public short IdUsuarioCreacion { get; set; }

    public DateTime FechaHoraCreacion { get; set; }

    public short IdUsuarioUltimaModificacion { get; set; }

    public DateTime FechaHoraUltimaModificacion { get; set; }

    public virtual EventoTipo IdEventoTipoNavigation { get; set; }

    public virtual Punto IdPuntoNavigation { get; set; }

    public virtual Usuario IdUsuarioCreacionNavigation { get; set; }

    public virtual Usuario IdUsuarioUltimaModificacionNavigation { get; set; }
}