create table [bbu].[Address]
(
	Id uniqueidentifier primary key,
	UnitNumber varchar(10),
	FullAddress varchar(300),
	StreetNumber varchar(10),
	StreetAddress varchar(100) not null,
	SubLocality varchar(100),
	Suburb varchar(100) not null,
	City varchar(100) not null,
	Province varchar(100),
	Country varchar(100),
	PostalCode varchar(5) not null,
	StateId int not null
);

create table [bbu].[AppUser]
(
	Id uniqueidentifier primary key,
	Fullname varchar(150) not null,
	FirstName varchar(75) not null,
	LastName varchar(75) not null,
	UniqueName varchar(15) not null,
	StateId int not null
);

create table [bbu].[Bank]
(
	Id int primary key,
	Name varchar(100) not null,
	StateId int not null
);

create table [bbu].[BankAccount]
(
	Id uniqueidentifier primary key,
	AccountNumber varchar(50) unique not null,
	AccountHolder varchar(100),
	BranchCode varchar(10),
	BranchName varchar(50),
	Reference varchar(100),
	BankId int not null,
	StateId int not null
);

create table [bbu].[Cemetery]
(
	Id uniqueidentifier primary key,
	Name varchar(100) not null,
	AddressId uniqueidentifier,
	StateId int not null
);

create table [bbu].[Credentials]
(
	AppUserId uniqueidentifier not null,
	Password varchar(50) not null,
	Username varchar(50) not null,
	StateId int not null,
	LastLogin datetime2
);

create table [bbu].[Deceased]
(
	PersonId uniqueidentifier not null,
	DateOfDeath date not null,
	PlaceOfDeath varchar(100),
	PlaceOfBodyRetrieval varchar(100),
	CauseOfDeath int,
	StateId int not null
);

create table [bbu].[Doctor]
(
	PersonId uniqueidentifier not null,
	PracticeNumber varchar(50),
	HospitalId uniqueidentifier,
	StateId int not null
);

create table [bbu].[Funeral]
(
	Id uniqueidentifier primary key,
	FuneralNumber varchar(50),
	GraveNumber varchar(50),
	BurialDate date,
	DeceasedId uniqueidentifier not null,
	InformantId uniqueidentifier,
	NextOfKin uniqueidentifier,
	DoctorId uniqueidentifier,
	HomeAffairsOfficerId uniqueidentifier,
	MortuaryId uniqueidentifier,
	CemeteryId uniqueidentifier,
	MemberId uniqueidentifier,
	CreatedOn datetime2 not null,
	CreatedById uniqueidentifier not null,
	ModifiedOn datetime2 not null,
	ModifiedById uniqueidentifier not null
);

create table [bbu].[Employee]
(
	PersonId uniqueidentifier not null,
	EmployeeNumber varchar(50) not null,
	StateId int not null
);

create table [bbu].[PurchaseItem]
(
	Id uniqueidentifier primary key,
	Name varchar(100) not null,
	Price float not null,
	Quantity int not null,
	FuneralId uniqueidentifier not null,
	SupplierId uniqueidentifier,
	StateId int
);

create table [bbu].[File]
(
	Id uniqueidentifier primary key,
	Name varchar(100),
	[FileName] varchar(500) not null,
	MimeType varchar(20),
	Size int,
	FileContent varchar(max)
);

create table [bbu].[FuneralDocument]
(
	Id uniqueidentifier not null,
	Name varchar(100) not null,
	[Description] varchar(max),
	FuneralId uniqueidentifier not null,
	CreatedById uniqueidentifier not null,
	CreatedOn datetime2 not null, 
	ModifiedById uniqueidentifier not null,
	ModifiedOn datetime2 not null,
	StateId int
);

create table [bbu].[Gender]
(
	Id int primary key,
	Name varchar(50),
	[Description] varchar(max),
);

create table [bbu].[HomeAffairsOffice]
(
	Id uniqueidentifier primary key,
	Name varchar(50),
	[Description] varchar(max),
);

create table [bbu].[HomeAffairsOfficer]
(
	PersonId uniqueidentifier not null,
	HomeAffairsOfficeId uniqueidentifier not null,
	AddressId uniqueidentifier,
	StateId int not null
);

create table [bbu].[Hospital]
(
	Id uniqueidentifier primary key,
	Name varchar(50),
	AddressId uniqueidentifier,
	StateId int not null
);

create table [bbu].[Informant]
(
	Id uniqueidentifier not null,
	RelationshipToDeceased varchar(50),
	StateId int not null
);

create table [bbu].[Member]
(
	PersonId uniqueidentifier not null,
	MemberNumber varchar(10),
	IsMainMember bit not null,
	ParentMemberId uniqueidentifier,
	StateId int not null
);

create table [bbu].[NextOfKin]
(
	Id uniqueidentifier not null,
	RelationshipToDeceased varchar(50),
	StateId int not null
);

create table [bbu].[Mortuary]
(
	Id uniqueidentifier primary key,
	Name varchar(100),
	AddressId uniqueidentifier,
	StateId int not null
);

create table [bbu].[Payment]
(
	Id uniqueidentifier primary key,
	MemberId uniqueidentifier not null,
	Amount float not null,
	PaymentPeriodId uniqueidentifier not null,
	DocumentId uniqueidentifier,
	CreatedOn datetime2 not null,
	CreatedById uniqueidentifier not null,
	StateId int not null
);


create table [bbu].[PaymentPeriod]
(
	Id uniqueidentifier primary key,
	Name varchar(100),
	[MonthName] varchar(50) not null,
	YearNumber int not null
);

create table [bbu].[Month]
(
	Name varchar(50)
);

create table [bbu].[Year]
(
	Number int
);

create table [bbu].[Person]
(
	Id uniqueidentifier primary key,
	FirstName varchar(100) not null,
	Lastname varchar(100) not null,
	MiddleName varchar(100),
	SaIdNumber varchar(13),
	DateOfBirth date,
	GenderId int,
	CellPhoneNumber varchar(13),
	EmailAddress varchar(50),
	AddressId uniqueidentifier,
	CreatedOn datetime2 not null,
	CreatedById uniqueidentifier not null,
	ModifiedOn datetime2 not null,
	ModifiedById uniqueidentifier not null,
	StateId int not null
);

create table [bbu].[Supplier]
(
	Id uniqueidentifier primary key,
	Name varchar(100),
	AddressId uniqueidentifier,
	StateId int not null
);

create table [bbu].[Task]
(
	Id uniqueidentifier primary key,
	Name varchar(100),
	[Description] varchar(max)
);

create table [bbu].[State]
(
	Id int primary key,
	Name varchar(50)
);

create table [bbu].[Setting]
(
	Id uniqueidentifier primary key,
	Name varchar(50),
	NumberOfRecordPerListPage int,
	NumberOfRecordPerLookupPage int
);

create table [bbu].[NumberConfiguration]
(
	Id uniqueidentifier primary key,
	EntityName varchar(100),
	[Length] int,
	IncrementBy int,
	NextNumber int,
	ZeroPad int,
	Prefix varchar(5),
	Suffix varchar(5),
	StateId int not null
);


