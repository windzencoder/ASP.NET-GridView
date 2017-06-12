Create Table tblEmployee
(
 EmployeeId int Primary key identity,
 Name nvarchar(50),
 Gender nvarchar(10),
 City nvarchar(50)
) 

Insert into tblEmployee values ('Mark','Male','London')
Insert into tblEmployee values ('John','Male','Chennai')
Insert into tblEmployee values ('Mary','Female','New York')
Insert into tblEmployee values ('Mike','Male','Sydeny')
Insert into tblEmployee values ('Pam','Female','Toronto')
Insert into tblEmployee values ('David','Male','Sydeny')

select * from tblEmployee;

update tblEmployee set Name='Dave' where EmployeeId = 6