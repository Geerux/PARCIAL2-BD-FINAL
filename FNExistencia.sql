USE [VENTAS]
GO
/****** Object:  UserDefinedFunction [dbo].[FN_EXISTENCIA]    Script Date: 25/03/2023 10:13:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[FN_EXISTENCIA] (@id_producto as INT)
RETURNS int


BEGIN
	--declare @id_producto int = 0
	--set @id_producto = 1

	DECLARE @CANTIDAD FLOAT
	SET @CANTIDAD=ISNULL((SELECT SUM(CD_CANTIDAD)FROM COMPRAS_DETALLE WHERE CD_ID_PRODUCTO= @id_producto),0)
	- isnull((SELECT SUM(VD_CANTIDAD)FROM VENTAS_DETALLE WHERE VD_ID_PRODUCTO= @id_producto),0)

	--select @CANTIDAD

	RETURN @CANTIDAD 
END

   
--WITH ENCRYPTION|SCHEMABINDING, ...
