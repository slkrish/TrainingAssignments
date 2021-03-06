use Zensar
-- 1.Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
--a)	HRA  as 10% Of sal
--b)	DA as  20% of sal
--c)	PF as 8% of sal
--d)	IT as 5% of sal
--e)	Deductions as sum of PF and IT
--f)	Gross Salary as sum of SAL,HRA,DA and Deductions
--g)	Net salary as  Gross salary- Deduction 

begin
declare @Salary float = 30000;
declare @SAL float,@HRA float,@DA float,@PF float,@IT float
declare @Deductions float, @GrossSAlary float, @NetSalary float

--a)HRA  as 10% Of sal
set @HRA = ((@Salary)*10/100)
print 'HRA is : '+''+cast(@HRA as varchar(10))


--b)DA as  20% of sal
set @DA =((@Salary)*20/100)
print 'DA is : '+''+cast(@DA as varchar(10))


--c)PF as 8% of sal
set @PF =((@Salary)*8/100)
print 'PF is : '+''+cast(@PF as varchar(10))


--d)IT as 5% of sal
set @IT =((@Salary)*5/100)
print 'IT is : '+''+cast(@IT as varchar(10))


--e)Deductions as sum of PF and IT
set @Deductions = @PF+@IT
print 'Deductions is : '+''+cast(@Deductions as varchar(10))


--f)Gross Salary as sum of SAL,HRA,DA and Deductions
set @SAL = @Salary -(@HRA+@DA+@Deductions)
set @GrossSAlary = @SAL+(@HRA+@DA+@Deductions)
print 'Gross Salary is : '+''+cast(@GrossSAlary as varchar(10))


--g)Net salary as  Gross salary- Deduction
set @NetSalary = @GrossSAlary-@Deductions
print 'Net Salary is : '+''+cast(@NetSalary as varchar(10))
end

--2.Write a T-SQL Program to find the factorial of a given number.

begin
declare @factorial int
	declare @number int
	set @number=3
	set @factorial=1
while @number>0
	begin
		set @factorial=@factorial*@number
		set @number=@number-1
	end
	print 'Factorial of a given number is : '+cast(@factorial as varchar)
end

--3.Create a stored procedure to generate multiplication tables up to a given number.

create or alter proc Multiplication_Table(@input int)
as
begin
 declare @number int = 1, @result int
 
  while(@number<=10)
  begin
    set @result = @input * @number
	print @result
  set @number = @number+1

  end
end

exec Multiplication_Table @input=10