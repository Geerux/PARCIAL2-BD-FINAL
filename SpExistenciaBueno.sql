USE [VENTAS]
GO
/****** Object:  StoredProcedure [dbo].[SP_EXISTENCIAS]    Script Date: 27/03/2023 07:21:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_EXISTENCIAS]
@VA varchar (500) = '',
@id_producto TINYINT = 0
AS
BEGIN 
	if @VA = 'boton'
	begin
		select a.AL_ID as id_producto,p.PR_NOMBRE as descripcion,(select dbo.FN_EXISTENCIA( @id_producto )) as existencia from ALMACENES a
		INNER JOIN dbo.PRODUCTOS p ON a.AL_ID = p.PR_ID
		where a.AL_ID = @id_producto 
	END
	else if @VA = 'masiva'
	begin
		select a.AL_ID as id_producto,p.PR_NOMBRE as descripcion,(select dbo.FN_EXISTENCIA( a.AL_ID )) as existencia from ALMACENES a
		INNER JOIN dbo.PRODUCTOS p ON a.AL_ID = p.PR_ID
	end
	else if @VA = 'llenaCombo'
	begin
		select * from almacenes
	end
	
END

