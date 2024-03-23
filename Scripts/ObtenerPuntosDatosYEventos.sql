SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2024-03-21
-- Description:	Obtiene los datos y los eventos de los puntos
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ObtenerPuntosDatosYEventos') AND type in (N'P', N'PC'))
	 DROP PROCEDURE ObtenerPuntosDatosYEventos
GO

CREATE PROCEDURE ObtenerPuntosDatosYEventos 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT p.IdPunto, p.Nombre AS PuntoNombre, p.Latitud, p.Longitud, pd.ChapaNumero, pd.IdEstablecimiento, e.Nombre AS EstablecimientoNombre, pe.IdEventoTipo, et.Nombre AS EventoTipoNombre, pe.FechaHora
		FROM Punto AS p
			INNER JOIN PuntoDato AS pd ON p.IdPunto = pd.IdPunto
			LEFT JOIN Establecimiento AS e ON pd.IdEstablecimiento = e.IdEstablecimiento
			LEFT JOIN PuntoEvento AS pe ON p.IdPunto = pe.IdPunto
			LEFT JOIN EventoTipo AS et ON pe.IdEventoTipo = et.IdEventoTipo
		WHERE pe.IdEvento IS NULL OR pe.IdEvento = (SELECT TOP 1 IdEvento FROM PuntoEvento WHERE IdPunto = p.IdPunto ORDER BY FechaHora DESC)
END
GO
