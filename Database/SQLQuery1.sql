create database PemudaThemePark
on(
name=PemudaThemePark,
filename='D:\Coding\Materi LKS IT software aplication\Latihan Bu Desti\1\Database\PemudaThemePark.mdf'
)

use PemudaThemePark


create table MembershipPlan(
PlanID varchar(10) primary key,
Periode int,
Harga int
)

create table Member(
MemberID varchar(10) primary key,
NamaMember varchar(30),
Alamat varchar(50),
Umur int
)

create table JoinMember(
JoinID varchar(10) primary key,
PlanID varchar(10) foreign key references MembershipPlan(PlanID) on update cascade on delete cascade,
MemberID varchar(10) foreign key references Member(MemberID) on update cascade on delete cascade,
TglGabung date,
TglBerhenti date
)

create table Ticket(
TicketID varchar(10) primary key,
Hari varchar(10),
Kategori varchar(15),
Harga int
)

create table Games(
GamesID varchar(10) primary key,
NamaGame varchar(20),
TglBangun date,
Umur int,
Kapasitas int,
Durasi int
)

create table Pegawai(
PegawaiID varchar(10) primary key,
NamaPegawai varchar(30),
Username varchar(20),
Pasword varchar(20),
Alamat varchar(50),
No_HP char(12),
Gender varchar(10),
)

create table Jabatan(
JabatanID varchar(10) primary key,
jabatan varchar(10)
)

create table TicketPurchase(
PurchaseID varchar(10) primary key,
TicketID varchar(10) foreign key references Ticket(TicketID) on update cascade on delete cascade,
MemberID varchar(10) foreign key references Member(MemberID) on update cascade on delete cascade,
PegawaiID varchar(10) foreign key references Pegawai(PegawaiID) on update cascade on delete cascade,
GamesID varchar(10) foreign key references Games(GamesID) on update cascade on delete cascade,
Tanggal date,
Qty int
)

create table Jadwal(
JadwalID varchar(10) Primary key,
Hari varchar(10),
Shiftt varchar(10)
)

create table GameShift(
ShiftID varchar(10) primary key,
GamesID varchar(10) foreign key references Games(GamesID) on update cascade on delete cascade,
PegawaiID varchar(10) foreign key references Pegawai(PegawaiID) on update cascade on delete cascade,
JadwalID varchar(10) foreign key references Jadwal(JadwalID) on update cascade on delete cascade
)

create table Attendance(
AttendanceID varchar(10) primary key,
PegawaiID varchar(10) foreign key references Pegawai(PegawaiID) on update cascade on delete cascade,
JadwalID varchar(10) foreign key references Jadwal(JadwalID) on update cascade on delete cascade,
Tanggal date,
Kehadiran varchar(10),
Telat int
)

create table Gaji(
GajiID varchar(10) primary key,
TipeGaji varchar(25),
Rate int,
Deskripsi varchar(80)
)

create table Pembayaran(
PembayaranID varchar(10) primary key,
GajiID varchar(10) foreign key references Gaji(GajiID) on update cascade on delete cascade,
AttendanceID varchar(10) foreign key references Attendance(AttendanceID) on update cascade on delete cascade,
TotalDailySalary int,
TotalOvertimeSalary int,
MonthlyBonus int,
TotalLateCharge int,
Total int
)

select * from Pegawai

delete from Jabatan where JabatanID=3

insert into Pegawai(PegawaiID,NamaPegawai,Username,Pasword,Alamat,No_HP,Gender,JabatanID)values(2,'Udin','Udinn','Udin123','Sungailiat,Bangka','081271324590','Laki-laki',2)

alter table Pegawai add JabatanID varchar(10) foreign key references Jabatan(JabatanID) on update cascade on delete cascade

select * from Jabatan

insert into Jabatan(JabatanID,jabatan)values(1,'Admin')
insert into Jabatan(JabatanID,jabatan)values(2,'Pegawai')

select * from Ticket
insert into Ticket(TicketID,Hari,Kategori,Harga)values(4,'Weekend','Adult',80000)


alter table [dbo].[MembershipPlan]
alter column Periode varchar(10)
go

select * from MembershipPlan where Periode='3 bulan'
insert into MembershipPlan(PlanID,Periode,Harga)values(3,'12 bulan',500000)

select * from Gaji
insert into Gaji(GajiID,TipeGaji,Rate,Deskripsi)values(4,'Late charge',5000,'Per late clock-in attendance/day')

select * from Games
insert into Games(GamesID,NamaGame,TglBangun,Umur,Kapasitas,Durasi)values(1,'Halilintar','2012-03-23',7,24,7)

select * from Jadwal order by JadwalID desc
insert into Jadwal(JadwalID,Hari,shiftt)values(14,'Minggu','Malam')
delete from Jadwal where JadwalID=10

select * from Joinmember
select * from Member
delete from Member where MemberID=3
select top(1) PegawaiID from Pegawai order by PegawaiID desc

select Joinmember.JoinID, JoinMember.PlanID, MembershipPlan.Periode from JoinMember
join MembershipPlan on Joinmember.PlanID=MembershipPlan.PlanID


select * from MembershipPlan
insert into JoinMember(JoinID,TglBerhenti)values(1,getdate())
delete from JoinMember where JoinID=1
update MembershipPlan set Periode=12 where PlanID=3

alter table [dbo].[Pegawai]
alter column Alamat text
go


select * from Pegawai
select * from jabatan
select top(1) PegawaiID from Pegawai order by PegawaiID desc

select Pegawai.NamaPegawai,Pegawai.Username,Pegawai.Pasword,Pegawai.Alamat,Pegawai.No_HP,Pegawai.Gender,Jabatan.jabatan from Pegawai
join Jabatan on Pegawai.JabatanID=Jabatan.JabatanID

select * from Games
select NamaGame, TglBangun, Umur, Kapasitas, Durasi from Games

select * from MembershipPlan
select top(1) PlanID from MembershipPlan order by PlanID desc

select * from Gaji
select top(1) GajiID from Gaji order by GajiID desc

select * from Attendance

insert into Pegawai(PegawaiID,NamaPegawai,Username,Pasword,Alamat,No_HP,Gender,JabatanID)values(1,'Layla','Laylaa','Layla123','Land of dawn','085290125939','Perempu')


select Jadwal.Hari, Jadwal.shiftt, Pegawai.NamaPegawai from Attendance
join Jadwal on Jadwal.JadwalID=Attendance.JadwalID
join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID


select * from GameShift

delete from Attendance where AttendanceID=5


select * from TicketPurchase
alter table TicketPurchase add total integer

select * from Ticket
select * from games
select * from Pegawai

select * from Member

select Member.NamaMember, Member.Umur, MembershipPlan.Periode, JoinMember.TglGabung, JoinMember.TglBerhenti from JoinMember
join Member on Member.MemberID=JoinMember.MemberID
join MembershipPlan on MembershipPlan.PlanID=JoinMember.PlanID
where Member.NamaMember='Alvin Indrawan'

delete from TicketPurchase where PurchaseID=7


select * from Attendance

select * from Pegawai

select Jadwal.Hari, Pegawai.NamaPegawai, Attendance.Tanggal, Attendance.Kehadiran, Attendance.Telat from Attendance
join Jadwal on Jadwal.JadwalID=Attendance.JadwalID
join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID


select * from Jadwal
insert into Jadwal(JadwalID,Shiftt)values(2,'Malam')

select * from Gameshift
alter table Gameshift add Tanggal date


select * from pembayaran

delete from Pembayaran where PembayaranID=2

alter table Pembayaran add TotalSalary int
alter table pembayaran drop column Total

select * from Games

select * from Attendance where Tanggal >='2019-05-01' and Tanggal<='2019-05-30'

select TglBangun from Games where month(TglBangun)='05'

select NamaPegawai from Pegawai
select Tanggal from Attendance



select Pegawai.NamaPegawai, Attendance.Kehadiran, Attendance.telat, Gaji.TipeGaji, Gaji.Rate from Pembayaran
join Attendance on Attendance.AttendanceID=Pembayaran.PembayaranID
join Gaji on Gaji.GajiID=Pembayaran.GajiID
join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID


select Jadwal.Hari, Pegawai.NamaPegawai, Attendance.Tanggal, Attendance.Kehadiran, Attendance.Telat from Attendance
join Jadwal on Jadwal.JadwalID=Attendance.JadwalID
join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID
where Pegawai.NamaPegawai='Udin'

select * from TicketPurchase


select Pegawai.NamaPegawai, Jadwal.hari, Jadwal.Shiftt from GameShift
join Pegawai on Pegawai.PegawaiID=GameShift.PegawaiID
join Jadwal on Jadwal.JadwalID=GameShift.JadwalID
where Jadwal.Hari='senin' and Jadwal.shiftt='pagi'

select * from Attendance

delete from Attendance where AttendanceID=6

delete from TicketPurchase where PurchaseID=5

alter table TicketPurchase drop column GamesID

select * from Ticket

select top(1) PurchaseID from TicketPurchase order by PurchaseID desc
insert into TicketPurchase(PurchaseID)values('T011')
delete from TicketPurchase where PurchaseID='T011'

select * from ticketpurchase

alter table TicketPurchase drop column total
alter table TicketPurchase add Total int

delete from Attendance where AttendanceID=1
alter table Attendance drop column Telat

select * from Attendance where PegawaiID=3 and Kehadiran='OverTime' and Tanggal>='2019-05-01' and Tanggal<='2019-05-31'

select Attendance.Tanggal,Jadwal.Shiftt,Pegawai.NamaPegawai, Attendance.Kehadiran from Attendance
                join Jadwal on Jadwal.JadwalID=Attendance.JadwalID
                join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID

select top(1) PegawaiID from Pegawai order by PegawaiID desc

select max(PegawaiID) from Pegawai

select * from Jabatan

insert into Jabatan(JabatanID,Jabatan)values(3,'Owner')
select * from Pegawai

insert into Pegawai(PegawaiID,NamaPegawai,Username,Pasword,Alamat,No_HP,Gender,JabatanID)values(11,'Indra','Indraa','Indra123','Sungailiat','No_HP','Laki-laki',3)

select * from Attendance

select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019 - 6 - 1' and Tanggal<='2019 - 6 - 31'