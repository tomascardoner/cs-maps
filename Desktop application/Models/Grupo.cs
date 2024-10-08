﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CSMaps.Models;

public partial class Grupo
{
    public short IdGrupo { get; set; }

    public string Nombre { get; set; }

    public string IconoMapaDireccion { get; set; }

    public string IconoMapaColor { get; set; }

    public string IconoMapaLeyendaTexto { get; set; }

    public byte? IconoMapaHotSpotX { get; set; }

    public string IconoMapaHotSpotXunits { get; set; }

    public byte? IconoMapaHotSpotY { get; set; }

    public string IconoMapaHotSpotYunits { get; set; }

    public bool EsActivo { get; set; }

    public short IdUsuarioCreacion { get; set; }

    public DateTime FechaHoraCreacion { get; set; }

    public short IdUsuarioUltimaModificacion { get; set; }

    public DateTime FechaHoraUltimaModificacion { get; set; }

    public virtual ICollection<GrupoPunto> GrupoPuntos { get; set; } = new List<GrupoPunto>();

    public virtual Usuario IdUsuarioCreacionNavigation { get; set; }

    public virtual Usuario IdUsuarioUltimaModificacionNavigation { get; set; }
}