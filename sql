CREATE DATABASE QLBanHang
GO
USE QLBanHang

CREATE TABLE ChiTietHoaDon(
    SoHD VARCHAR(20),
    TenSP NVARCHAR(100),
    SoLuong INT,
    DonGia MONEY
)

INSERT INTO ChiTietHoaDon VALUES
('HD01',N'Sách Toán',2,15000),
('HD01',N'Sách Văn',1,20000),
('HD02',N'Truyện top 8 ban đêm',10,5000)


