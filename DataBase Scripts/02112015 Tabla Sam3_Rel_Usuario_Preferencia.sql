
DROP TAble Sam3_Rel_Usuario_Preferencia

CREATE TABLE Sam3_Rel_Usuario_Preferencia (
Rel_Usuario_PreferenciaID int NOT NULL PRIMARY KEY Identity(1,1),
UsuarioID int NOT NULL FOREIGN KEY REFERENCES Sam3_Usuario(UsuarioID),
PreferenciaID int NOT NULL FOREIGN KEY REFERENCES Sam3_Preferencia(PreferenciaId),
ValorPreferencia varchar(100) NOT NULL,
Activo bit NOT NULL,
UsuarioModificacion int,
FechaModificacion datetime
)
