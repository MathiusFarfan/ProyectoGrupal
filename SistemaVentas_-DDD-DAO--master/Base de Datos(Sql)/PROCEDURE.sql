
USE SIVET
GO




CREATE OR ALTER PROC U_MOD_PASSWOR
	@PID_BUSCAR INT,
	@PPASSWOR VARCHAR(32),
	@PPTIP BIT
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN E_MOD_PASSWOR_R
				
				IF(@PPTIP=1)
				BEGIN
					UPDATE Usuarios
					SET Contrasena=@PPASSWOR
					FROM Empleados E
					WHERE E.Id_Usuario=Usuarios.Id_Usuario AND E.Id_Empleado=@PID_BUSCAR
				END
				ELSE IF(@PPTIP=0)
				BEGIN
					UPDATE Usuarios
					SET Contrasena=@PPASSWOR
					FROM Clientes C
					WHERE C.Id_Usuario=Usuarios.Id_Usuario AND C.Id_Cliente=@PID_BUSCAR
				END
			COMMIT TRAN E_MOD_PASSWOR_R
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN E_MOD_PASSWOR_R
		END CATCH
	END
GO


CREATE OR ALTER PROC U_REGISTRAR
	--USUARIO
	@PDNI VARCHAR(8),
	@PNOMBRES VARCHAR(128),
	@PAPELLIDOS VARCHAR(128),
	@PDIRECCION VARCHAR(128),
	@PEMAIL VARCHAR(54),
	@PCELULAR VARCHAR(9),
	@PCONTRASENA VARCHAR(32)
AS
	BEGIN
		DECLARE @COD INT
		INSERT INTO Usuarios VALUES (@PDNI,@PNOMBRES,@PAPELLIDOS,@PDIRECCION,@PEMAIL,@PCELULAR,@PCONTRASENA) 
		SET @COD=IDENT_CURRENT('Usuarios')
		SELECT value=@COD
	END
GO


--PAQUETE EMPLEADOS


CREATE OR ALTER PROC E_INSERT
    --EMPLEADO
	@PCOD_USUARIO INT,
	@PAREA VARCHAR(64),
	@PCARGO VARCHAR(64)
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN E_INSERT_U
				INSERT INTO Empleados VALUES (@PCOD_USUARIO,@PAREA,@PCARGO,1) 
			COMMIT TRAN E_INSERT_U
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN E_INSERT_U
		END CATCH
	END
GO




CREATE OR ALTER PROC E_BUSCAR
	@PBUSCAR VARCHAR(128)
AS
	BEGIN
		

		IF(@PBUSCAR!='')
		BEGIN
			SELECT E.Id_Empleado,U.Nombres,U.Apellidos,E.Area,E.Cargo,e.EstadoActivo
			FROM Empleados E
			JOIN Usuarios U
			ON E.Id_Usuario=U.Id_Usuario
			WHERE DNI = @PBUSCAR
		END
		ELSE
		BEGIN
			SELECT E.Id_Empleado,U.Nombres,U.Apellidos,E.Area,E.Cargo,e.EstadoActivo
			FROM Empleados E
			JOIN Usuarios U
			ON E.Id_Usuario=U.Id_Usuario
		END
	END
GO



CREATE OR ALTER PROC E_ACTIVAR
	@PID_EMPLEADO INT
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN E_ACT_R
				UPDATE Empleados
				SET EstadoActivo=1
				WHERE Empleados.Id_Empleado=@PID_EMPLEADO
			COMMIT TRAN E_ACT_R
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN E_ACT_R
		END CATCH
	END
GO

CREATE OR ALTER PROC E_DESACTIVAR
	@PID_EMPLEADO INT
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN E_DES_R
				UPDATE Empleados
				SET EstadoActivo=0
				WHERE Empleados.Id_Empleado=@PID_EMPLEADO


			COMMIT TRAN E_DES_R
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN E_DES_R
		END CATCH
	END
GO



--PAQUETE CLIENTES



CREATE OR ALTER PROC C_INSERT
    @PID_USUARIO INT
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN C_INSERT_U
				INSERT INTO Clientes VALUES (@PID_USUARIO) 
			COMMIT TRAN C_INSERT_U
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN C_INSERT_U
		END CATCH
	END
GO



CREATE OR ALTER PROC C_BUSCAR
	@PBUSCAR VARCHAR(128)
AS
	BEGIN
		IF(@PBUSCAR!='')
		BEGIN 
			SELECT C.Id_Cliente,U.DNI,U.Nombres,U.Apellidos,U.DireccioN,U.Celular,U.EMAIL
			FROM Clientes C
			JOIN Usuarios U
			ON C.Id_Usuario=U.Id_Usuario
			WHERE U.DNI=@PBUSCAR
		END
		ELSE
		BEGIN
			SELECT C.Id_Cliente,U.DNI,U.Nombres,U.Apellidos,U.DireccioN,U.Celular,U.EMAIL
			FROM Clientes C
			JOIN Usuarios U
			ON C.Id_Usuario=U.Id_Usuario
		END
	END
GO



CREATE OR ALTER PROC C_ACTUALIZAR
	@PID_CLIENTE INT,
	@PEMAIL VARCHAR(54),
	@PCELULAR VARCHAR(9)
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN C_ACTUALIZAR_R
				UPDATE Usuarios
				SET Usuarios.Celular=@PCELULAR,
				Usuarios.EMAIL=@PEMAIL
				FROM Clientes C
				WHERE Usuarios.Id_Usuario=C.Id_Usuario AND C.Id_Cliente=@PID_CLIENTE
			COMMIT TRAN C_ACTUALIZAR_R
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN C_ACTUALIZAR_R
		END CATCH
	END
GO

--PAQUETE PEDIDOS

--PEDIDOS


CREATE OR ALTER PROC P_REGISTRAR_PEDIDO
	@PID_CLIENTE INT,
	@IDESTADOPEDIDO smallint,
	@PPEDIDOGRANDE BIT,
	@PTOTALNUMERIC NUMERIC(10,2)

AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN P_REGISTRAR_PEDIDO_R
				DECLARE @COD INT
				
				INSERT INTO Pedidos VALUES (@PID_CLIENTE,@IDESTADOPEDIDO,@PPEDIDOGRANDE,GETDATE(),@PTOTALNUMERIC)
				SET @COD=IDENT_CURRENT('Pedidos')
				SELECT value=@COD
			COMMIT TRAN P_REGISTRAR_PEDIDO_R
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN P_REGISTRAR_PEDIDO_R
		END CATCH
	END
GO



CREATE OR ALTER PROC P_LISTAR_PEDIDOS
	@DNI VARCHAR(128)
AS
	BEGIN
		IF(@DNI!='')
		BEGIN
			SELECT P.Id_Pedido,U.Nombres,P.TotalEstimado,P.FechaEstimada
			FROM Pedidos P
			JOIN Clientes C
			ON C.Id_Cliente=P.Id_Cliente
			JOIN Usuarios U
			ON U.Id_Usuario=C.Id_Usuario
			WHERE U.DNI=@DNI
		END
		ELSE
		BEGIN
			SELECT P.Id_Pedido,U.Nombres,P.TotalEstimado,P.FechaEstimada
			FROM Pedidos P
			JOIN Clientes C
			ON C.Id_Cliente=P.Id_Cliente
			JOIN Usuarios U
			ON U.Id_Usuario=C.Id_Usuario
		END
	END
GO
CREATE OR ALTER PROC P_APROBAR_PEDIDO_GRANDE
	@PID_PEDIDO INT
AS
	BEGIN
		UPDATE Pedidos
		SET Id_Estado_Pedido=1
		WHERE Pedidos.Id_Estado_Pedido=@PID_PEDIDO
	END
GO

CREATE OR ALTER PROC P_CANCELAR_PEDIDO_GRANDE
	@PID_PEDIDO INT
AS
	BEGIN
		UPDATE Pedidos
		SET Id_Estado_Pedido=2
		WHERE Pedidos.Id_Estado_Pedido=@PID_PEDIDO
	END
GO

-- ESTADO PEDIDO
 
CREATE OR ALTER PROC EP_BUSCAR_ESTADO_PEDIDO
	@PID_PEDIDO INT
AS
	BEGIN
		SELECT EP.Nombre
		FROM EstadoPedido EP 
		JOIN Pedidos P
		ON P.Id_Estado_Pedido=EP.Id_Estado_Pedido
		WHERE P.Id_Pedido=@PID_PEDIDO
	END
GO


--DETALLE PEDIDO

CREATE OR ALTER PROC DP_REGISTRAR
	@PCOD_PEDIDO INT,
	@PID_MATERIAL INT,
	@PCANTIDAD SMALLINT,
	@PPRECIOUNIT NUMERIC(5,2),
	@SUBTOTAL NUMERIC(12,2)
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN DP_REGISTRAR_R
				INSERT INTO Detalles_Pedido VALUES (@PCOD_PEDIDO,@PID_MATERIAL,@PCANTIDAD,@PPRECIOUNIT,@SUBTOTAL)
			COMMIT TRAN DP_REGISTRAR_R
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN DP_REGISTRAR_R
		END CATCH
	END
GO



CREATE OR ALTER PROC DP_BUSCAR_P
	@ID_PEDIDO INT
AS
	BEGIN
		SELECT DP.Id_Material,M.Nombre,DP.CantidaD,DP.PrecioUnit,DP.Subtotal
		FROM Detalles_Pedido DP
		JOIN Materiales M
		ON DP.Id_Material=M.Id_Material
		JOIN Pedidos P
		ON P.Id_Pedido=DP.Id_Pedido
		JOIN Clientes C
		ON C.Id_Cliente=P.Id_Cliente
		WHERE @ID_PEDIDO=P.Id_Pedido
	END
GO
--MATERIAL

CREATE OR ALTER PROC M_BUSCAR
	@PBUSCADO VARCHAR(32)
AS
	BEGIN
		IF(@PBUSCADO!='')
		BEGIN
			SELECT M.Id_Material,M.Nombre,M.Descripcion,M.Unidad,M.PrecioUnit,M.Stock
			FROM Materiales M
			WHERE M.Nombre LIKE @PBUSCADO+'%'
		END
		ELSE
		BEGIN
			SELECT M.Id_Material,M.Nombre,M.Descripcion,M.Unidad,M.PrecioUnit,M.Stock
			FROM Materiales M
		END
	END
GO


CREATE OR ALTER PROC M_ACTUALIZAR_MATERIAL
    @PID_MATERIAL INT,
    @PPRECIOUNIT NUMERIC(5,2)
AS
    BEGIN
        BEGIN TRY
            BEGIN TRAN M_ACTUALIZAR_MATERIAL_R

                UPDATE Materiales
                SET Materiales.PrecioUnit=@PPRECIOUNIT
				WHERE Id_Material=@PID_MATERIAL;

            COMMIT TRAN M_ACTUALIZAR_MATERIAL_R
        END TRY
        BEGIN CATCH
            ROLLBACK tran M_ACTUALIZAR_MATERIAL_R
        END CATCH
    END
GO

CREATE OR ALTER PROC M_AUMENTAR_STOCK
	@PID_MATERIAL INT,
	@PCANTIDAD INT
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN M_AUMENTAR_STOCK_R

				DECLARE @ID_LIMITEVENTA INT
				DECLARE @STOCK_ACT INT

				UPDATE Materiales
				SET @STOCK_ACT=Materiales.Stock,Materiales.Stock=Materiales.Stock + @PCANTIDAD
				WHERE Materiales.Id_Material=@PID_MATERIAL


			COMMIT TRAN M_AUMENTAR_STOCK_R
		END TRY
		BEGIN CATCH
			ROLLBACK tran M_AUMENTAR_STOCK_R
		END CATCH
	END
GO
CREATE OR ALTER PROC M_REGISTRAR
	@PNOMBRE VARCHAR(32),
	@PDESCRIPCION VARCHAR(128),
	@PPRECIOUNIT NUMERIC(5,2),
	@PUNIDAD VARCHAR(16),
	@PSTOCK INT,
	@PDESCPORCENTAJE NUMERIC(5,2)
AS
	BEGIN
		DECLARE @PCOD_ID SMALLINT
		DECLARE @PPORCEN INT
		SET @PPORCEN=100
	    --yy/mm/dd hh
		INSERT INTO LimitesVenta VALUES (@PPORCEN,@PDESCPORCENTAJE,GETDATE())
		SET @PCOD_ID=IDENT_CURRENT('LimitesVenta')
		INSERT INTO Materiales VALUES (@PCOD_ID,@PNOMBRE,@PDESCRIPCION,@PPRECIOUNIT,@PUNIDAD,@PSTOCK)
	END
GO



CREATE OR ALTER PROC LOG
	@PEMAIL VARCHAR(8),
	@PCONTRASENA VARCHAR(9)
AS
	BEGIN
		
		DECLARE @COD INT,@CODUS INT

		SELECT @COD=U.Id_Usuario
		FROM Usuarios U
		WHERE U.Contrasena=@PCONTRASENA AND U.EMAIL=@PEMAIL

		print @COD

		IF (EXISTS(SELECT * FROM Clientes WHERE Clientes.Id_Usuario=@COD))
		BEGIN
			
			SELECT @CODUS=Clientes.Id_Cliente FROM Clientes WHERE Clientes.Id_Usuario=@COD
			SELECT value=1 ,value=@CODUS
			print '1'
		END
		ELSE IF (EXISTS(SELECT * FROM Empleados WHERE Empleados.Id_Usuario=@COD))
		BEGIN
			SELECT @CODUS=Empleados.Id_Empleado FROM Empleados WHERE Empleados.Id_Usuario=@COD
			SELECT value=2 ,value=@CODUS
			print '2'
		END
	END	
GO


--PAQUETE FACTURAS

CREATE OR ALTER PROC F_GENERARFACTURA
    --FACTURA
	@PSERIEFACTURA INT,
	@PIDCLIENTE INT,
	@IDEMPLEADO INT,
	@PSUBTOTAL NUMERIC(5,2),
	@PDESCUENTO NUMERIC(5,2),
	@PIGV NUMERIC(5,2),
	@PCOSTOTOAL NUMERIC(6,2)
AS
	BEGIN
		BEGIN TRY
			BEGIN TRAN M_CREARFACTURA_R
				DECLARE @COD INT
				
				INSERT INTO Facturas VALUES (@PSERIEFACTURA,@PIDCLIENTE,@IDEMPLEADO,GETDATE(),@PSUBTOTAL,@PDESCUENTO,@PIGV,@PCOSTOTOAL)
				SET @COD=IDENT_CURRENT('Facturas')
				SELECT value=@COD
			COMMIT TRAN M_CREARFACTURA_R
		END TRY
		BEGIN CATCH
			ROLLBACK tran M_CREARFACTURA_R
		END CATCH
	END
GO



--Limite de Venta
CREATE OR ALTER PROC LV_BUSCAR
	@PID SMALLINT
AS
	SELECT L.Id_LimitesVenta,L.Porcentaje,L.DescPorcentaje,L.FechaUltimoCambio
	FROM LimitesVenta L
	JOIN Materiales M
	ON L.Id_LimitesVenta=M.Id_LimitesVenta
	WHERE M.Id_Material=@PID
GO

--DETALLE FACTURA


CREATE OR ALTER PROC DF_REGISTRAR
	@PNROFACTURA SMALLINT,
	@PIDMATERIAL INT,
	@PCANTIDAD INT,
	@PPRECIOUNIT NUMERIC(5,2),
	@PSUBTOTAL NUMERIC(5,2)
AS
	INSERT INTO Detalles_Factura VALUES (@PNROFACTURA,@PIDMATERIAL,@PCANTIDAD,@PPRECIOUNIT,@PSUBTOTAL)
GO



CREATE OR ALTER PROC DF_BUSCAR
	@NROFACTURA int
AS
	SELECT M.Nombre,DF.Cantidad,DF.PrecioUnit,DF.Subtotal FROM Detalles_Factura  DF JOIN Materiales M ON m.Id_Material=DF.Id_Material WHERE @NROFACTURA =DF.Nrofactura
GO



