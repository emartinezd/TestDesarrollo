/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [TipoIncidenciaID]
      ,[Nombre]
      ,[Activo]
      ,[FechaModificacion]
      ,[UsuarioModificacion]
  FROM [steelgo-sam3].[dbo].[Sam3_TipoIncidencia]

  INSERT INTO Sam3_TipoIncidencia
  VALUES ('PreDespacho', 1, '2015-10-24', 1)