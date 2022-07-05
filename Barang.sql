CREATE PROC spDataBarang
AS
	Select * from tbBarang
Go
EXEC spDataBarang

CREATE PROCEDURE spCariDataBarang @Cari varchar(50)
AS 
	SELECT * FROM tbBarang WHERE Id_Barang LIKE '%' +@Cari+ '%' OR Nama_Barang LIKE '%' +@Cari+ '%'
GO

EXECUTE spCariDataBarang 'arti'


EXEC spDataBarang

CREATE PROCEDURE spIdBarang
AS 
	select Id_Barang from tbBarang where Id_Barang in(select max(id_barang) from tbBarang) order by Id_Barang desc
GO

EXECUTE spIdBarang


CREATE PROC spInputBarang @IDBARANG varchar(50), @NAMA varchar(50),
						 @HARGA int, @STOK int, @DESC varchar(50)
AS
	INSERT INTO tbBarang(Id_Barang,Nama_Barang,Harga,Stok,Deskripsi)
	VALUES(@IDBARANG, @NAMA, @HARGA, @STOK, @DESC)
Go
EXEC spInputBarang 'BRG004', 'Buket Beng-beng',50000 , 5, 'PO 3 Hari'