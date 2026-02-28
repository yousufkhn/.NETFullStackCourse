create database OnboardingDB;

use OnboardingDB;

Create table Candidates(
	CandidateId int primary key identity(1,1),
	FullName varchar(100),
	Email varchar(100),
	College varchar(100),
	CGPA Decimal(3,2),
	Skills varchar(200),
	InterviewScore INT,
	Status varchar(50),
	CreatedDate Datetime default GETDATE()
);

Alter table candidates 
alter column FullName varchar(100) not null;

alter table candidates
alter column Email varchar(100) not null;

Select * from Candidates;

Insert into Candidates(fullname,email,college,cgpa,skills,InterviewScore,Status) values ('Yousuf','khanyousuf2144@gmail.com','Lovely Professional University',8.24,'WebDevelopemt,.NET',100,'Selected');