﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CSMaps.Models;

public partial class UsuarioGrupoPermiso
{
    public byte IdUsuarioGrupo { get; set; }

    public short IdPermiso { get; set; }

    public short IdUsuarioCreacion { get; set; }

    public virtual Permiso IdPermisoNavigation { get; set; }

    public virtual Usuario IdUsuarioCreacionNavigation { get; set; }

    public virtual UsuarioGrupo IdUsuarioGrupoNavigation { get; set; }
}