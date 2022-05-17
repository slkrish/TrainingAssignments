--QUERY TO DISPLAY AGE IN DAYS
select DATEDIFF(dd,'1999/05/30','2022/05/30') AS DOB_NOOF_DAYS

-- CREATE EMP8 TABLE 

create table EMP8
 (Empid int primary key,
  Name varchar(10),
  Salary int,
  Deptno int);
  alter table EMP8 add constraint salcheck check( salary between 5000 and 50000)
