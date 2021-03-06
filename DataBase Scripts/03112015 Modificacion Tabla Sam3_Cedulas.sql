
ALTER TABLE Sam3_ItemCodeSteelgo
DROP CONSTRAINT FK__Sam3_Item__Cedul__7F36D027

DROP TABLE Sam3_Cedula

  CREATE TABLE Sam3_Cedula
  (
  CedulaID int Primary Key Identity(1,1),
  DiametroID int FOREIGN KEY REFERENCES Sam3_Diametro(DiametroID),
  CedulaA varchar(50),
  CedulaB varchar(50),
  CedulaC varchar(50),
  CedulaIn decimal(7,4) NOT NULL,
  CedulaMM decimal(7,4) NOT NULL,
  Espesor decimal(7,4) NOT NULL,
  Activo bit NOT NULL,
  UsuarioModificacion int,
  FechaModificacion datetime
  )

INSERT INTO Sam3_Cedula VALUES(1, 'STD', '40', '600#', 0.933, 23.6982, 23.6982, 1, 1, NULL)

UPDATE Sam3_ItemCodeSteelgo
SET CedulaID = 1

ALTER TABLE [dbo].Sam3_ItemCodeSteelgo  WITH CHECK ADD FOREIGN KEY(CedulaID)
REFERENCES [dbo].Sam3_Cedula (CedulaID)
GO
