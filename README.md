--Insert data
Create proc SP_Student_Insert
@Full_name varchar(100),
@Index_no nchar(10),
@Aca_year nchar(5),
@Mobile int,
@Gender varchar(6),
@DOB date,
@Language varchar(50)
as 
begin
insert into StudentTable (Full_name, Index_no, Aca_year, Mobile, Gender, DOB, Language) 
values (@Full_name, @Index_no, @Aca_year, @Mobile, @Gender, @DOB, @Language)
end


--All read

Create proc SP_Student_View
as 
begin
select * from StudentTable
end

Drop proc SP_Student_View


--Update records

Create proc SP_Student_Update
@Full_name varchar(100),
@Index_no nchar(10),
@Aca_year nchar(5),
@Mobile int,
@Gender varchar(6),
@DOB date,
@Language varchar(50)
as 
begin
Update StudentTable set Full_name = @Full_name, Index_no = @Index_no, Aca_year = @Aca_year, Mobile = @Mobile, Gender =@Gender, DOB = @DOB, Language =@Language
end

--Delete records

Create proc SP_Student_Delete
@Index_no  nchar(10)
as 
begin
Delete StudentTable where Index_no = @Index_no
end

--Select specific record
Create proc SP_Student_Search
@Index_no  nchar(10)
as 
begin
Select * from StudentTable where Index_no = @Index_no
end
