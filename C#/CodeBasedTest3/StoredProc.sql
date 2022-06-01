create table Code_Employee ( empno int primary key, 
empname varchar(50) not null, 
empsal numeric(10,2) check(empsal >= 25000) , 
emptype varchar(1) check(emptype in('C','P')) ) 

select * from Code_Employee

create or alter procedure spinsert(@empname varchar(20),@empsal numeric(10,2),@emptype varchar(1))
as
begin
 declare @maxempno int
		 select @maxempno= case
		 when max(empno)is null then 0
		 else max(empno)
		 end 
		 from Code_Employee
		 
		 set @maxempno = @maxempno + 1
		 
		 insert into Code_Employee
		 values(@maxempno,@empname,@empsal,@emptype)

 end
