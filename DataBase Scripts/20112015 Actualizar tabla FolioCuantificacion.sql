begin tran
begin try
	alter table Sam3_FolioCuantificacion add Consecutivo int null default(0), Rel_Proyecto_Entidad_Configuracion_ID INT NULL
	ALTER TABLE Sam3_FolioCuantificacion ADD CONSTRAINT FK_FolioCuantificacion_Rel_Proyecto_Entidad_Configuracion
	FOREIGN KEY (Rel_Proyecto_Entidad_Configuracion_ID) REFERENCES dbo.Sam3_Rel_Proyecto_Entidad_Configuracion(Rel_Proyecto_Entidad_Configuracion_ID);

	UPDATE Sam3_FolioCuantificacion SET Consecutivo=0
	commit tran
end try
begin catch
	rollback tran
end catch



