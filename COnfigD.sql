
alter view dbo.ConfigSourceDestination
--select * from dbo.ConfigSourceDestination

AS

SELECT 
1 AS ConfigSourceDestinationID 
,'Integrated Security=SSPI;Persist Security Info=False;database=NORTHWND;Data Source=GRIFF-PC\SQLEXPRESS2014' AS SourceConnectionString
, 'dbo.Products' AS SourceObject
 ,'Integrated Security=SSPI;Persist Security Info=False;database=NORTHWND;Data Source=GRIFF-PC\SQLEXPRESS2014' AS DestinationConnectionString
, 'dbo.TargetProducts' AS DestinationObject

UNION ALL

SELECT 2
,'Integrated Security=SSPI;Persist Security Info=False;database=NORTHWND;Data Source=GRIFF-PC\SQLEXPRESS2014' AS SourceConnectionString
 ,'dbo.Suppliers' AS SourceObject
 ,'Integrated Security=SSPI;Persist Security Info=False;database=NORTHWND;Data Source=GRIFF-PC\SQLEXPRESS2014' AS DestinationConnectionString
,  'dbo.TargetSuppliers' AS DestinationObject

create procedure dbo.pr_DropDownSourceConnectionString
--drop procedure dbo.pr_DropDownSourceConnectionString

AS

select distinct SourceConnectionString
from dbo.ConfigSourceDestination

go 

exec  dbo.pr_DropDownSourceConnectionString

alter procedure dbo.pr_DropDownSourceObject
@sourceconnectionstring varchar(1000)

AS

select distinct SourceObject
from dbo.ConfigSourceDestination
where sourceconnectionstring = @sourceconnectionstring ;
go

exec  dbo.pr_DropDownSourceObject 'Integrated Security=SSPI;Persist Security Info=False;database=NORTHWND;Data Source=GRIFF-PC\SQLEXPRESS2014';
go

create procedure dbo.pr_GetDestinationDetails
 @sourceconnectionstring varchar(1000), @sourceobject varchar(1000)

as

select DestinationConnectionString, DestinationObject 
 from dbo.ConfigSourceDestination
where DestinationConnectionString = @sourceconnectionstring 
and DestinationObject= @sourceobject;
