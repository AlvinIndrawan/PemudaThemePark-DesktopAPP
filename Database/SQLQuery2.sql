select * from Pembayaran

alter table Pembayaran drop column WorkSalary

select Pegawai.NamaPegawai, Attendance.Kehadiran, Gaji.TipeGaji, Gaji.Rate from Pembayaran
join Attendance on Attendance.AttendanceID=Pembayaran.PembayaranID
join Gaji on Gaji.GajiID=Pembayaran.GajiID
join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID

select Pegawai.NamaPegawai, Pembayaran.Bulan, Pembayaran.DailySalary, Pembayaran.Overtimesalary, Pembayaran.MonthlyBonus, Pembayaran.LateCharge, Pembayaran.total from Pembayaran

create table Bulanan(
BulananID varchar(10),
PegawaiID varchar(10) foreign key references Pegawai(PegawaiID) on update cascade on delete cascade,
Bulan varchar(10),
JumlahAbsent int,
JumlahOvertime int,
JumlahLate int
)

select * from Bulanan
alter table Bulanan add JumlahKerja int

alter table Pembayaran add BulananID varchar(10) foreign key references Bulanan(BulananID) on update cascade on delete cascade


select Pegawai.NamaPegawai, Bulanan.Bulan, Bulanan.JumlahAbsent, Bulanan.JumlahOvertime, Bulanan.Jumlahlate, Pembayaran.TotalDailySalary, Pembayaran.TotalOvertimesalary, Pembayaran.Monthlybonus, Pembayaran.TotalLatecharge, Pembayaran.totalsalary from Pembayaran
join Bulanan on Bulanan.BulananID=Pembayaran.BulananID
join Pegawai on Pegawai.PegawaiID=Bulanan.PegawaiID
where 


select * from Attendance where PegawaiID=5 and Kehadiran='Absent' and Tanggal>='2019-05-01' and Tanggal<='2019-05-31'

delete from Bulanan where BulananID=2

insert into Bulanan(BulananID)values('T15')
select * from Bulanan order by BulananID
select max(right(BulananID,2))from Bulanan

select max(BulananID) from Bulanan

select top(1)right(BulananID,2)from Bulanan order by BulananID desc

select * from GameShift

select * from Pembayaran
delete from Pembayaran where PembayaranID=4
select * from Bulanan
delete from Bulanan where BulananID=4

select Pegawai.NamaPegawai,Bulanan.JumlahAbsent, Bulanan.JumlahOvertime, Bulanan.JumlahLate, Pembayaran.TotalDailysalary, Pembayaran.TotalOvertimeSalary, Pembayaran.MonthlyBonus, Pembayaran.TotalLateCharge, Pembayaran.TotalSalary from Pembayaran
join Bulanan on Bulanan.BulananID=Pembayaran.BulananID
join Pegawai on Pegawai.PegawaiID=Bulanan.PegawaiID
where Bulanan.Bulan='Mei'

select sum(Pembayaran.TotalSalary) from Pembayaran
join Bulanan on Bulanan.BulananID=Pembayaran.BulananID
join Pegawai on Pegawai.PegawaiID=Bulanan.PegawaiID
where Bulanan.Bulan='Mei'

create table RekapGaji(
RekapID int primary key,
Bulan varchar(10),
Gaji int
)

select * from RekapGaji