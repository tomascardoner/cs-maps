﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using CSMaps.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace CSMaps.Models
{
    public partial class CSMapsContext
    {
        private ICSMapsContextProcedures _procedures;

        public virtual ICSMapsContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new CSMapsContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public ICSMapsContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObtenerPuntosDatosYEventosResult>().HasNoKey().ToView(null);
        }
    }

    public partial class CSMapsContextProcedures : ICSMapsContextProcedures
    {
        private readonly CSMapsContext _context;

        public CSMapsContextProcedures(CSMapsContext context)
        {
            _context = context;
        }

        public virtual async Task<List<ObtenerPuntosDatosYEventosResult>> ObtenerPuntosDatosYEventosAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<ObtenerPuntosDatosYEventosResult>("EXEC @returnValue = [dbo].[ObtenerPuntosDatosYEventos]", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
