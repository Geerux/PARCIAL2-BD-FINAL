USE [VENTAS]
GO
/****** Object:  StoredProcedure [dbo].[SP_CLIENTES_PARCIAL]    Script Date: 27/03/2023 09:20:09 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	ALTER PROCEDURE [dbo].[SP_CLIENTES_PARCIAL]
@OP  TINYINT = 0,
@CL_ID TINYINT = 0,
@CL_NOMBRE VARCHAR (200) = NULL,
@CL_RFC CHAR (13) = NULL,
@CL_CORREO CHAR (200) = NULL,
@CL_LADA CHAR (3) = NULL,
@CL_TELEFONO CHAR (7) = NULL,
@CL_CALLE VARCHAR (150) = NULL,
@CL_NUMERO_EXT CHAR (10) = NULL,
@CL_CTABANCARIA VARCHAR (150) = NULL,
@CL_CONTACTO VARCHAR (150) = NULL,
@CL_TELEFONO_CONTACTO CHAR (10) = NULL,
@CL_REGIMEN CHAR (3) = NULL
AS
BEGIN
	IF @OP = 1
	BEGIN
		-- OBTIENE EL CONSECUTIVO DEL CLIENTE -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		
		IF NOT EXISTS (SELECT * FROM CLIENTES WHERE CL_ID = @CL_ID)
			BEGIN
				SET @CL_ID = (SELECT ISNULL(MAX(CL_ID),0) + 1 FROM CLIENTES)
				INSERT INTO CLIENTES ( CL_ID, CL_NOMBRE, CL_RFC, CL_CORREO, CL_LADA, CL_TELEFONO, CL_CALLE, CL_NUMERO_EXT, CL_CTABANCARIA, CL_CONTACTO, CL_TELEF_CONTACTO, CL_REGIMEN)
				VALUES ( @CL_ID, @CL_NOMBRE, @CL_RFC, @CL_CORREO, @CL_LADA, @CL_TELEFONO, @CL_CALLE, @CL_NUMERO_EXT, @CL_CTABANCARIA, @CL_CONTACTO, @CL_TELEFONO_CONTACTO, @CL_REGIMEN)
			END
		
		
	END
	IF @OP = 2
			BEGIN
				UPDATE CLIENTES SET CL_NOMBRE = @CL_NOMBRE , CL_RFC = @CL_RFC, CL_CORREO = @CL_CORREO, CL_LADA = @CL_LADA, CL_TELEFONO = @CL_TELEFONO , CL_CALLE = @CL_CALLE, CL_NUMERO_EXT = @CL_NUMERO_EXT , CL_CTABANCARIA = @CL_CTABANCARIA , CL_CONTACTO = @CL_CONTACTO , CL_TELEF_CONTACTO = @CL_TELEFONO_CONTACTO, CL_REGIMEN = @CL_REGIMEN
				WHERE CL_ID = @CL_ID
			END
	---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	IF @OP = 3
	BEGIN
			DELETE FROM CLIENTES WHERE CL_ID = @CL_ID
	END
END
