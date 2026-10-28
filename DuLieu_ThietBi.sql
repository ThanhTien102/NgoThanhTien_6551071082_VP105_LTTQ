create database DuLieu_ThietBi;

use DuLieu_ThietBi;
go

create table ThietBi (
	MaThietBi nvarchar(10) primary key,
	TenThietBi ntext not null,
	DonGia nvarchar(12) not null,
);
insert into ThietBi(MaThietBi, TenThietBi, DonGia) values
('TB001',N'Máy tính xách tay Dell', '15.000.000'),
('TB002',N'Máy in HP LaserJet', '5.500.000'),
('TB003',N'Màn Hình Samsung', '3.800.000'),
('TB004',N'Bàn phím cơ Logitech', '1.200.000'),
('TB005',N'Chuột không dây', '450.000');