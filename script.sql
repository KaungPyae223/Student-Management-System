USE [master]
GO
/****** Object:  Database [Student1]    Script Date: 9/22/2022 8:54:29 PM ******/
CREATE DATABASE [Student1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student1', FILENAME = N'C:\Users\User\Desktop\K.H.N\Student1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Student1_log', FILENAME = N'C:\Users\User\Desktop\K.H.N\Student1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Student1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student1] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Student1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Student1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student1] SET RECOVERY FULL 
GO
ALTER DATABASE [Student1] SET  MULTI_USER 
GO
ALTER DATABASE [Student1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Student1]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Course]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Course]

@ID int = 0,
@Action int = 0,
@Detail varchar(max) ='',
@Fee int =0,
@Name varchar(50) ='',
@ShortForm varchar(10)='',
@duriation varchar(10)=''

as begin
	if @Action=1
		Insert into Course values (@Name,@duriation,@Fee,@Detail,@ShortForm)
	if @Action=0
		Update Course set CourseName=@Name,courseDuration=@duriation,CourseFee=@Fee,CourseDetail=@Detail,shortform=@ShortForm where CourseID = @ID
	if @Action=2
		delete from Course where CourseID = @ID
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_Register]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Register]
@para1 varchar(50) ='',
@StudentID int =0,
@registrationdate varchar(50) ='',
@note varchar(50) ='',
@user int =0,
@action int = 0,
@ID int = 0
as begin
	if @action=0
		insert into Registration (SchduleID,StudentID,RegistrationDate,note,UserID) values (@para1,@StudentID,@registrationdate,@note,@user)
		
	if @Action=1
		delete from Registration where RegistrationID = @ID
	if @action=2
		update Registration set SchduleID=@para1,StudentID=@StudentID,RegistrationDate=@registrationdate,note=@note,UserID=@user where RegistrationID = @ID 
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_Room]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Room]
@roomname nvarchar(50)='',
@available int = 0,
@action int = 0,
@ID int =0
as begin

if @action=0
	insert into Room values (@roomname,@available)

if @action=1
	update Room set RoomName=@roomname,available=@available where RoomNo = @ID 
if @action=2
	delete Room where RoomNo=@ID
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_Schdule]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Schdule]
@suID varchar(10) ='',
@couID int = 0,
@roomID int =0,
@SectionID int =0,
@timeID int =0,
@start varchar(15) ='',
@userID int = 0,
@action int = 0
as begin
	if @action = 0
		insert into Schdule1 values (@suID,@couID,@roomID,@SectionID,@timeID,@start,@userID)
	if @action = 1
		delete from Schdule1 where SchduleID = @suID
		if @Action=2
		delete from Schdule1 where SchduleID = @suID
	if @action = 3
		Update Schdule1 set StartDate=@start where SchduleID = @suID

end
GO
/****** Object:  StoredProcedure [dbo].[Insert_Section]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Section]
@Name varchar(50) ='',
@day varchar(50)='',
@action int =0,
@ID int =0
as begin 
if @action = 0
	insert into Section values (@Name,@day)

if @action = 1
	Update Section set Date=@day, SectionName=@Name where SectionID = @ID

if @action =2
	delete Section where SectionID = @ID
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_Student]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Student]

@StudentID int = 0,
@StudentName varchar(150) = '',
@Phone varchar(30) = '',
@NRC varchar(50)='',
@Gmail varchar(50)='',
@Address varchar(50)='',
@Action int=0,
@key varchar(50) = ''
as begin

if @Action=0
	insert into Student values(@StudentName,@Phone,@NRC,@Gmail,@Address)
if @Action=1
	update Student set Name=@StudentName, Phone=@Phone,NRC=@NRC,Gmail=@Gmail,Address=@Address where StudentID=@StudentID
if @Action=2
	delete from Student where StudentID=@StudentID
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_Time]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Time]
@Time varchar(30) ='',
@action int = 0,
@ID int = 0
as begin
if @action = 0
	Update Time1 set time=@Time where TimeID = @ID
if @action = 1
	Insert into Time1 values (@Time)
if @action = 2
	delete  Time1 where TimeID = @ID
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_User]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_User]
@name varchar(50) ='',
@password varchar(50) ='',
@Level varchar(50) ='',
@id int = 0,
@action int =0

as begin
if @action = 1
	Insert into UserTable values (@name,@Level,ENCRYPTBYPASSPHRASE(@password,@name))
if @action =2
	Update UserTable set Password1 = ENCRYPTBYPASSPHRASE(@password,@name) where Username = @name
if @action =3
	Delete from UserTable where UserID=@id
end

GO
/****** Object:  StoredProcedure [dbo].[Select_Course]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Course]
@para1 varchar(50) ='',
@para2 varchar(50)='',
@action int =0
as begin
if @action =0
	Select ROW_NUMBER() over(order by courseName) as NO, * from Course order by CourseName
if @action=1
	select * from course where CourseName = @para1 or shortform = @para2
if @action=2
	select ROW_NUMBER() over(order by CourseName) as NO, * from Course where CourseName like @para1 +'%' order by CourseName
end

GO
/****** Object:  StoredProcedure [dbo].[Select_Register]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Register]
@para1 varchar(50) ='',
@para2 varchar(50) ='',
@id int =0,
@action int =0
as begin
	if @action=0
            Select * from Student where Name=@para1 and Address=@para2
    if @action=1
            Select * from Registration where SchduleID=@para1 and StudentID=@id
    if @action=2
            Select ROW_NUMBER() over(order by RegistrationID) as NO, * from vi_Register order by RegistrationID
    if @action=3
            select ROW_NUMBER() over(Order by SchduleID) as No, * From Registration order by RegistrationID
    if @action=4
            select ROW_NUMBER() over(Order by Name) as No, * From vi_Register order by RegistrationID
    if @action=5
        select ROW_NUMBER() over(order by RegistrationID) as No,* from vi_Register where SchduleID like @para1+'%' order by RegistrationID
    if @action=6
        select ROW_NUMBER() over(order by RegistrationID) as No,* from vi_Register where Name like @para1+'%' order by RegistrationID
	if @action=7
            select ROW_NUMBER() over(Order by CourseName) as No, * From vi_Register order by RegistrationID
	if @action=8
        select ROW_NUMBER() over(order by CourseName) as No,* from vi_Register where CourseName like @para1+'%' order by RegistrationID
	if @action=9
         select ROW_NUMBER() over(Order by UserName) as No, * From vi_Register order by RegistrationID
	if @action=10
        select ROW_NUMBER() over(order by UserName) as No,* from vi_Register where UserName like @para1+'%' order by RegistrationID

end
GO
/****** Object:  StoredProcedure [dbo].[Select_Room]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Room]

@roomname varchar(50) ='',
@action int = 0
as begin
if @action=0
	select * from Room where RoomName = @roomname

if @action=1
	select ROW_NUMBER() over(order by roomname) as NO, * from Room order by RoomName
if @action=2
	select ROW_NUMBER() over(order by roomname) as NO, * from Room where RoomName like @roomname +'%' order by RoomName
end

GO
/****** Object:  StoredProcedure [dbo].[Select_Schdule]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Schdule]
@Name varchar(50) ='',
@date varchar(20) = '',
@action int =0,
@para1 int =0,
@para2 int =0
as begin
	if @action=0
		Select * from Course
	if @action=1
		Select * from Room
	if @action=2
		select * from Section
	if @action=3
		select * from Time1
	if @action=4
		select * from Schdule1 where SchduleID like @Name+'%'order by SchduleID desc
	if @action=5
		Select DATEDIFF(D,Getdate(),@date)as NO
	if @action=6
		Select ROW_NUMBER() over (order by StartDate desc) as No, * from vi_Schdule order by StartDate desc
	if @action=7
		select ROW_NUMBER() over(Order by SchduleID) as No, *From vi_Schdule order by SchduleID
	if @action=8
		select ROW_NUMBER() over(order by SchduleID) as No,* from vi_Schdule where Date like @Name+'%' order by SchduleID
	if @action=9
		select ROW_NUMBER() over(order by SchduleID) as No,* from vi_Schdule where RoomName like @Name+'%' order by SchduleID
	if @action=10
		select ROW_NUMBER() over(order by SchduleID) as No,* from vi_Schdule where CourseName like @Name+'%' order by SchduleID
	if @action=11
		select ROW_NUMBER() over(order by SchduleID) as No,* from vi_Schdule where UserName like @Name+'%' order by SchduleID
	if @action=12
		select * from Schdule1 where SectionID = @para1 and TimeID = @para2 and StartDate = @date
	if @action=13
		select * from Registration where SchduleID = @Name
end
GO
/****** Object:  StoredProcedure [dbo].[Select_Section]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Section]
@action int = 0,
@name varchar(20)='',
@day varchar(20)=''
as begin
if @action=0
	Select * from Section where SectionName = @name or Date = @day
if @action=1
	Select ROW_NUMBER() over (order by sectionName)as NO, * from Section order by SectionName
if @action=2
	Select ROW_NUMBER() over (order by sectionName)as NO, * from Section where Date like @day+'%' order by SectionName
	
end

GO
/****** Object:  StoredProcedure [dbo].[Select_Student]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Student]
@para1 varchar(50)='',
@para2 varchar(50)='',
@para3 varchar(50)='',
@action int =0

as begin

if @action=0
	Select * from Student where Name=@para1 and Gmail = @para2
if @action=1
	Select ROW_NUMBER() over (Order by Name) as NO, * from Student order by Name
if @action=2
	Select ROW_NUMBER() over (Order by Name) as NO, * from Student where Name like @para1+'%' order by Name	
if @action=3
	Select ROW_NUMBER() over (Order by Name) as NO, * from Student where Address like @para1+'%' order by Name	
if @action=4
	Select ROW_NUMBER() over (Order by Name) as NO, * from Student where Gmail like @para1+'%' order by Name
if @action=5
	Select ROW_NUMBER() over (Order by Name) as NO, * from Student where Phone like @para1+'%' order by Name
end

GO
/****** Object:  StoredProcedure [dbo].[Select_Time]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_Time]
@para1 varchar(30) ='',
@action int =0
as begin
if @action=0
	Select * from Time1 where TIme = @para1
if @action=1
	Select ROW_NUMBER() over (order by Time) as NO,* from Time1 order by TIme
end

GO
/****** Object:  StoredProcedure [dbo].[Select_User]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Select_User]
@para1 varchar(50),
@pass varchar(50),
@ID int = 0,
@action int = 0
as begin
	if @action=0
		Select ROW_NUMBER() over(order by UserName) as NO, * from UserTable order by UserName
	if @action=1
		Select * from UserTable where UserID = @ID
	if @action=2
		Select CONVERT(varchar(50),DECRYPTBYPASSPHRASE(@pass,Password1))as Password,UserID,UserLevel from UserTable where UserName = @para1 and UserID = @ID
	if @action=3
	Select ROW_NUMBER() over (order by UserID)as NO, * from UserTable where UserName like @para1+'%' order by UserID
end

GO
/****** Object:  Table [dbo].[Course]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
	[courseDuration] [char](10) NOT NULL,
	[CourseFee] [int] NOT NULL,
	[CourseDetail] [varchar](max) NULL,
	[shortform] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[RegistrationID] [int] IDENTITY(1,1) NOT NULL,
	[SchduleID] [varchar](50) NULL,
	[StudentID] [int] NOT NULL,
	[RegistrationDate] [varchar](50) NULL,
	[note] [varchar](max) NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[RegistrationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[RoomNo] [int] IDENTITY(1,1) NOT NULL,
	[RoomName] [varchar](50) NOT NULL,
	[available] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schdule1]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schdule1](
	[SchduleID] [char](10) NOT NULL,
	[CourseID] [int] NOT NULL,
	[RoomNo] [int] NOT NULL,
	[SectionID] [int] NOT NULL,
	[TimeID] [int] NOT NULL,
	[StartDate] [varchar](15) NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Schdule1] PRIMARY KEY CLUSTERED 
(
	[SchduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Section]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Section](
	[SectionID] [int] IDENTITY(1,1) NOT NULL,
	[SectionName] [varchar](10) NOT NULL,
	[Date] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED 
(
	[SectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[Phone] [varchar](max) NULL,
	[NRC] [varchar](max) NULL,
	[Gmail] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Time1]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Time1](
	[TimeID] [int] IDENTITY(1,1) NOT NULL,
	[TIme] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Time1] PRIMARY KEY CLUSTERED 
(
	[TimeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserLevel] [varchar](50) NOT NULL,
	[Password1] [varchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vi_Register]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vi_Register]
AS
SELECT dbo.Schdule1.SchduleID, dbo.Registration.RegistrationID, dbo.Student.Name, dbo.Registration.RegistrationDate, dbo.Schdule1.StartDate, dbo.Course.CourseName, dbo.Registration.note, dbo.UserTable.UserName, dbo.Student.Address, 
                  dbo.Student.StudentID, dbo.Schdule1.RoomNo
FROM     dbo.Course INNER JOIN
                  dbo.Schdule1 ON dbo.Course.CourseID = dbo.Schdule1.CourseID INNER JOIN
                  dbo.UserTable ON dbo.Schdule1.UserID = dbo.UserTable.UserID INNER JOIN
                  dbo.Registration ON dbo.UserTable.UserID = dbo.Registration.UserID AND dbo.Schdule1.SchduleID = dbo.Registration.SchduleID INNER JOIN
                  dbo.Student ON dbo.Registration.StudentID = dbo.Student.StudentID

GO
/****** Object:  View [dbo].[vi_Schdule]    Script Date: 9/22/2022 8:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vi_Schdule]
AS
SELECT dbo.Schdule1.SchduleID, dbo.Schdule1.CourseID, dbo.Schdule1.RoomNo, dbo.Schdule1.SectionID, dbo.Schdule1.TimeID, dbo.Schdule1.StartDate, dbo.Schdule1.UserID, dbo.Section.Date, dbo.Room.RoomName, dbo.Room.available, 
                  dbo.Course.CourseName, dbo.Time1.TIme, dbo.UserTable.UserName
FROM     dbo.Schdule1 INNER JOIN
                  dbo.Section ON dbo.Schdule1.SectionID = dbo.Section.SectionID INNER JOIN
                  dbo.Room ON dbo.Schdule1.RoomNo = dbo.Room.RoomNo INNER JOIN
                  dbo.Course ON dbo.Schdule1.CourseID = dbo.Course.CourseID INNER JOIN
                  dbo.Time1 ON dbo.Schdule1.TimeID = dbo.Time1.TimeID INNER JOIN
                  dbo.UserTable ON dbo.Schdule1.UserID = dbo.UserTable.UserID

GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTable] ([UserID])
GO
ALTER TABLE [dbo].[Schdule1]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTable] ([UserID])
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Course"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 244
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Schdule1"
            Begin Extent = 
               Top = 7
               Left = 292
               Bottom = 170
               Right = 486
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "UserTable"
            Begin Extent = 
               Top = 135
               Left = 547
               Bottom = 298
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Registration"
            Begin Extent = 
               Top = 7
               Left = 776
               Bottom = 170
               Right = 983
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Student"
            Begin Extent = 
               Top = 7
               Left = 1031
               Bottom = 170
               Right = 1225
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vi_Register'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vi_Register'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vi_Register'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[67] 4[3] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Schdule1"
            Begin Extent = 
               Top = 9
               Left = 34
               Bottom = 231
               Right = 281
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Section"
            Begin Extent = 
               Top = 7
               Left = 404
               Bottom = 197
               Right = 651
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Room"
            Begin Extent = 
               Top = 0
               Left = 686
               Bottom = 190
               Right = 933
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Course"
            Begin Extent = 
               Top = 207
               Left = 361
               Bottom = 429
               Right = 612
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Time1"
            Begin Extent = 
               Top = 207
               Left = 669
               Bottom = 365
               Right = 916
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "UserTable"
            Begin Extent = 
               Top = 260
               Left = 62
               Bottom = 482
               Right = 309
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vi_Schdule'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vi_Schdule'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vi_Schdule'
GO
USE [master]
GO
ALTER DATABASE [Student1] SET  READ_WRITE 
GO
