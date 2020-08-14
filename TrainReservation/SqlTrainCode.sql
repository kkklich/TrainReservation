--create database Train

create table SittingPlace(
Id_place int primary key identity (1,1),
Nr_car int ,
Nr_siting int not null,
Class varchar(10)
)



create table Station(
Id_station int primary key identity (1,1),
Name_station varchar(50) not null
)

--create table Relation(
--Id_relation int primary key identity (1,1),
--Id_station1 int foreign key references Station(Id_station) not null, 
--Id_station2 int foreign key references Station(Id_station) not null,
--Distance float,
--TimeStart varchar(20),
--TimeEnd varchar(20),
--StartorEnd int,
--Nr_line int
--)



create table Relation(
Id_relation int primary key identity (1,1),
Id_station int foreign key references Station(Id_station) not null, 
Distance float,
TimeCome datetime ,
TimeLeave datetime ,
NumberStation int not null,
Nr_line int not null , 
Nr_relation int not null
)




create table Ticket(
Id_tic int primary key identity (1,1),
Id_place int foreign key references SittingPlace(id_place),
Id_relation1 int foreign key references Relation(Id_relation),
Id_relation2 int foreign key references Relation(Id_relation)

)




insert into Station
values('Katowice')
insert into Station
values('Sosnowiec')
insert into Station
values('Zawiercie')
insert into Station
values('Warszawa')
insert into Station
values('Gdañsk')
insert into Station
values('Sopot')
insert into Station
values('Kraków')
insert into Station
values('Opole')
insert into Station
values('Wroc³aw')


insert into Relation
values(1,0,'2020-08-12 10:24','2020-08-12 10:34',0,10,1)
insert into Relation
values(3,124,'2020-08-12 11:44','2020-08-12 11:46',1,10,1)
insert into Relation
values(4,234,'2020-08-12 13:14','2020-08-12 13:34',2,10,1)
insert into Relation
values(5,350,'2020-08-12 15:04','2020-08-12 15:14',3,10,1)


insert into Relation
values(1,0,'2020-08-12 12:24','2020-08-12 12:34',0,10,2)
insert into Relation
values(3,124,'2020-08-12 13:44','2020-08-12 13:46',1,10,2)
insert into Relation
values(4,234,'2020-08-12 15:14','2020-08-12 15:34',2,10,2)
insert into Relation
values(5,350,'2020-08-12 17:04','2020-08-12 17:14',3,10,2)


insert into Relation
values(7,0,'2020-08-12 11:04','2020-08-12 12:14',0,9,3)
insert into Relation
values(1,80,'2020-08-12 13:34','2020-08-12 13:40',1,9,3)
insert into Relation
values(8,90,'2020-08-12 14:44','2020-08-12 14:45',2,9,3)
insert into Relation
values(9,110,'2020-08-12 15:24','2020-08-12 15:30',3,9,3)



insert into Relation
values(7,0,'2020-08-12 14:04','2020-08-12 15:14',0,9,4)
insert into Relation
values(1,80,'2020-08-12 16:34','2020-08-12 16:40',1,9,4)
insert into Relation
values(8,90,'2020-08-12 17:44','2020-08-12 17:45',2,9,4)
insert into Relation
values(9,110,'2020-08-12 18:24','2020-08-12 18:30',3,9,4)


insert into SittingPlace
values(1,33,'1')

insert into SittingPlace
values(1,32,'1')
insert into SittingPlace
values(2,12,'2')
insert into SittingPlace
values(2,3,'2')
insert into SittingPlace
values(2,30,'2')
insert into SittingPlace
values(1,24,'1')
insert into SittingPlace
values(1,23,'1')

insert into Ticket
values(1,2,4)
insert into Ticket
values(3,1,3)
insert into Ticket
values(5,2,3)


select  r.Nr_relation, sum(distance) as 'odleglosc km'
from Relation r join Station s on r.Id_station=s.Id_station
--where Id_relation >2 AND Id_relation<=4
group by r.Nr_relation


select *
from Relation r join Station s on r.Id_station=s.Id_station
where r.Nr_line=10

select *
from SittingPlace

select *
from Station



create view TravelInfo as
select Nr_car,Nr_siting,Class, r.timeleave,s1.Name_station as 'FromStation',r2.TimeCome,s.Name_station as 'ToStation',r2.Distance-r.Distance as 'km'
from Ticket t join SittingPlace p on t.Id_place=p.Id_place
join Relation r on t.Id_relation1=r.Id_relation
join Station s1 on r.Id_station=s1.Id_station
join Relation r2 on t.Id_relation2=r2.Id_relation
join Station s on r2.Id_station=s.Id_station


select *
from TravelInfo

DECLARE @time time(4) = '9:30:00';  
DECLARE @datetime datetime = @time;  
  
SELECT @datetime AS '@datetime', @time AS '@time';  

insert into time
values(@time)

--insert into time
--values('2020-07-23 11:44:00')

select *
from time





--declare @hour datetime='12:43:00'

declare @fulltime datetime
set @fulltime=  @time+'12:43:00'
select @time
--select @hour
select @fulltime

declare @i as int=1;
declare @time datetime='2020-08-12';

while @i<10
begin

declare @fulltime datetime;
declare @fulltimeleave datetime;

set @fulltime=  @time+'10:24';
set @fulltimeleave=@time+'10:34';
insert into Relation
values(1,0,@fulltime,@fulltimeleave,0,11)

set @fulltime=  @time+'11:44';
set @fulltimeleave=@time+'11:46';
insert into Relation
values(3,124,@fulltime,@fulltimeleave,1,11)

set @fulltime=@time+'13:14';
set @fulltimeleave=@time+'13:34'
insert into Relation
values(4,234,@fulltime,@fulltimeleave,2,11)

set @fulltime=@time+'15:04';
set @fulltimeleave=@time+'15:14';
insert into Relation
values(5,350,@fulltime,@fulltimeleave,3,11)


--insert into time
--values(@fulltime)

set @i=@i+1;
set @time= dateadd(day,1,@time);
end

select Id_relation, r.Id_station,Distance,FORMAT(r.TimeCome,'dd/MM/yyyy, hh:mm:ss','pl-PL') as date
from Relation r join Station s on r.Id_station=s.Id_station

select  *
from  Relation r join Station s on r.Id_station=s.Id_station
where Name_station like 'Katowice' OR  Name_station like 'Warszawa'
where Nr_line=11 AND  month(r.TimeCome)=10 AND DAY(r.TimeCome)=27 

--dodaæ coœ takiejak numer kursu do relation

