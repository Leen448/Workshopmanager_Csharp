USE [WorkshopDB]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 17/08/42 01:58:03 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[UserPassword] [varchar](288) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Audience]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audience](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[AudPassword] [varchar](288) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Audience] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organaizer_Admin]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organaizer_Admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrgName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[OrgAdmPassword] [varchar](288) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Organaizer_Admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organaizer_Employee]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organaizer_Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[EmpPassword] [varchar](288) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[OrganizerID] [int] NOT NULL,
 CONSTRAINT [PK_Organaizer_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Attendance] [bit] NOT NULL,
	[WorkshopID] [int] NOT NULL,
	[OrganaizerID] [int] NOT NULL,
	[AudienceID] [int] NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workshop]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workshop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[WDate] [varchar](100) NOT NULL,
	[Duration] [varchar](288) NOT NULL,
	[Presenter] [varchar](50) NOT NULL,
	[SeatsCount] [varchar](50) NOT NULL,
	[WLocation] [varchar](50) NOT NULL,
	[Seat_full_flag] [bit] NOT NULL,
	[OrgID] [int] NOT NULL,
	[WDescription] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Workshop] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([ID], [FName], [LName], [Email], [UserPassword], [Phone]) VALUES (2, N'Leena', N'Alamri', N'Leena@gmail.com', N'12543', N'+9661234314')
INSERT [dbo].[Admin] ([ID], [FName], [LName], [Email], [UserPassword], [Phone]) VALUES (3, N'Ranim', N'Almuslim', N'Ranim@gmail.com', N'65432', N'+9663141847')
INSERT [dbo].[Admin] ([ID], [FName], [LName], [Email], [UserPassword], [Phone]) VALUES (4, N'Dina', N'Fahad', N'Dina@gmail.com', N'1234', N'+97489623765')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Audience] ON 

INSERT [dbo].[Audience] ([ID], [FName], [LName], [Email], [AudPassword], [Phone]) VALUES (2, N'Yara', N'Nader', N'Yara@gmail.com', N'32415', N'+96612324133')
INSERT [dbo].[Audience] ([ID], [FName], [LName], [Email], [AudPassword], [Phone]) VALUES (3, N'Leena', N'alamri', N'Leena@hotmail.com', N'1234', N'0987654477')
INSERT [dbo].[Audience] ([ID], [FName], [LName], [Email], [AudPassword], [Phone]) VALUES (4, N'Sara', N'ahmad', N'SA@hotmail.com', N'1234', N'098723526543')
INSERT [dbo].[Audience] ([ID], [FName], [LName], [Email], [AudPassword], [Phone]) VALUES (5, N'Ranim', N'Almuslim', N'ran@gmail.com', N'1348807', N'+965138441')
SET IDENTITY_INSERT [dbo].[Audience] OFF
GO
SET IDENTITY_INSERT [dbo].[Organaizer_Admin] ON 

INSERT [dbo].[Organaizer_Admin] ([ID], [OrgName], [Email], [OrgAdmPassword], [Phone]) VALUES (1, N'Misk', N'Admin@misk.com', N'14325', N'+96653151413')
INSERT [dbo].[Organaizer_Admin] ([ID], [OrgName], [Email], [OrgAdmPassword], [Phone]) VALUES (2, N'MCIT', N'Admin@mcit.com', N'54322', N'+96612415344')
INSERT [dbo].[Organaizer_Admin] ([ID], [OrgName], [Email], [OrgAdmPassword], [Phone]) VALUES (3, N'CISCO NETWORKING ACADEMY
', N'CISCO_ACADEMY
@cisco.co', N'1532344', N'+96613418179')
SET IDENTITY_INSERT [dbo].[Organaizer_Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Organaizer_Employee] ON 

INSERT [dbo].[Organaizer_Employee] ([ID], [FName], [LName], [Email], [EmpPassword], [Phone], [OrganizerID]) VALUES (2, N'Fahad', N'Ahmad', N'Fahad@mcit.com', N'65859', N'+96613535141344', 2)
INSERT [dbo].[Organaizer_Employee] ([ID], [FName], [LName], [Email], [EmpPassword], [Phone], [OrganizerID]) VALUES (3, N'Dina', N'Ahmad', N'Dina@misk.com', N'1234', N'+98765432347', 1)
SET IDENTITY_INSERT [dbo].[Organaizer_Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 

INSERT [dbo].[Registration] ([ID], [Attendance], [WorkshopID], [OrganaizerID], [AudienceID]) VALUES (125, 1, 2, 1, 3)
INSERT [dbo].[Registration] ([ID], [Attendance], [WorkshopID], [OrganaizerID], [AudienceID]) VALUES (130, 1, 2, 1, 2)
INSERT [dbo].[Registration] ([ID], [Attendance], [WorkshopID], [OrganaizerID], [AudienceID]) VALUES (131, 0, 11, 1, 2)
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
SET IDENTITY_INSERT [dbo].[Workshop] ON 

INSERT [dbo].[Workshop] ([ID], [Title], [WDate], [Duration], [Presenter], [SeatsCount], [WLocation], [Seat_full_flag], [OrgID], [WDescription]) VALUES (1, N'Fundamental of Python programming', N'11/08/42 10:52:06', N'23', N'MOHAMED ABDULLA MOSTAFA', N'50', N'Online', 0, 1, N'This workshop designed for people who want to learn Python programming language for web and desktop applications or information and data.')
INSERT [dbo].[Workshop] ([ID], [Title], [WDate], [Duration], [Presenter], [SeatsCount], [WLocation], [Seat_full_flag], [OrgID], [WDescription]) VALUES (2, N'Linux Fundamental', N'11/08/42 10:52:06 ', N'4', N'Saeed Zain', N'61', N'Online', 0, 1, N'Linux basic is an introduction to Linux as an operating system and provides the trainee with basic open source concepts. . The course content provides a virtual environment for using Linux, step-by-step training exercises, practical access to concepts, and use of the Linux command line. This course is the ideal starting point for understanding and acquiring basic skills for using the Linux operating system.')
INSERT [dbo].[Workshop] ([ID], [Title], [WDate], [Duration], [Presenter], [SeatsCount], [WLocation], [Seat_full_flag], [OrgID], [WDescription]) VALUES (9, N'Linkedin: How to set up a Linkedin profile from sc', N'20/08/42 11:13:32', N'2', N'Ahmad majed', N'99', N'Online', 0, 2, N'This training isn’t a basic training, in this workshop, I’ll share with you the strategies you should use to set up a converting profile from scratch.
In this lesson you will learn:
How to upload a profile photo and best practices that will help you standout
Why you should set your location to the closest major city in your area and how
Creative headlines and how to make sure yours attracts the opportunities you crave
Tips for creating a relevant summary and not just a highlight of your resume')
INSERT [dbo].[Workshop] ([ID], [Title], [WDate], [Duration], [Presenter], [SeatsCount], [WLocation], [Seat_full_flag], [OrgID], [WDescription]) VALUES (11, N'Network Security', N'27/08/42 11:40:09', N'4', N'Sara Ahmad', N'70', N'Online', 0, 1, N'Welcome to this comprehensive course on Network Hacking! In this course, you will start as a beginner with no previous knowledge about penetration testing or hacking and by the end of it you''ll be at an intermediate level being able to hack into networks and connected devices like black-hat hackers and secure them like security experts.')
SET IDENTITY_INSERT [dbo].[Workshop] OFF
GO
ALTER TABLE [dbo].[Registration] ADD  CONSTRAINT [DF_Registration_Attendance]  DEFAULT ((0)) FOR [Attendance]
GO
ALTER TABLE [dbo].[Workshop] ADD  CONSTRAINT [DF_Workshop_Seat_full_flag]  DEFAULT ((0)) FOR [Seat_full_flag]
GO
ALTER TABLE [dbo].[Organaizer_Employee]  WITH CHECK ADD  CONSTRAINT [FK_Organaizer_Employee_Organaizer_Admin] FOREIGN KEY([OrganizerID])
REFERENCES [dbo].[Organaizer_Admin] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organaizer_Employee] CHECK CONSTRAINT [FK_Organaizer_Employee_Organaizer_Admin]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Audience] FOREIGN KEY([AudienceID])
REFERENCES [dbo].[Audience] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Audience]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Organaizer_Admin] FOREIGN KEY([OrganaizerID])
REFERENCES [dbo].[Organaizer_Admin] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Organaizer_Admin]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Workshop] FOREIGN KEY([WorkshopID])
REFERENCES [dbo].[Workshop] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Workshop]
GO
/****** Object:  StoredProcedure [dbo].[AddNewAudience]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[AddNewAudience] 
@FName varchar(50),
@LName varchar(50),
@Email varchar(100),
@AudPassword varchar(288),
@Phone varchar(50)
AS
BEGIN
	if(exists(select Email from Audience where Email=@Email))
		BEGIN
			print 'This user is already exist.'
		END
	Else
		BEGIN
			insert into Audience(FName,LName,Email,AudPassword,Phone)
			  values(@FName,@LName,@Email,@AudPassword,@Phone)
		END
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewOrganaizer_Admin]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddNewOrganaizer_Admin]
@Name varchar(50) ,
@Email varchar(100),
@Password varchar(288),
@Phone varchar(50)
as 
BEGIN 
  IF (exists( select Email From Organaizer_Admin where Email=@Email))
    BEGIN
      print 'This organizer is already exist'
    END
  ELSE
   BEGIN
     insert into Organaizer_Admin(OrgName,Email,OrgAdmPassword,Phone)values(@Name,@Email,@Password,@Phone)
   END
END
GO
/****** Object:  StoredProcedure [dbo].[AddNewOrgEmp]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddNewOrgEmp]
@FName varchar(50) ,
@LName varchar(50),
@Email varchar(100),
@Password varchar(288),
@Phone varchar(50),
@OrganizerID int
as 
BEGIN
  if (exists( select Email From Organaizer_Employee where Email=@Email))
    BEGIN
      print 'This employee is already exist'
    End
  else
   BEGIN
     insert into Organaizer_Employee(FName,LName,Email,EmpPassword,Phone,OrganizerID)
	 values(@FName,@LName,@Email,@Password,@Phone,@OrganizerID)
   End
End
GO
/****** Object:  StoredProcedure [dbo].[AddNewWorkshop]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------Add New Workshop------------
CREATE proc [dbo].[AddNewWorkshop]

@Title varchar(50),
@Date varchar(100),
@Duration varchar(288),
@Presenter varchar(50),
@SeatsCount varchar(50),
@Location varchar(50),
@Description varchar(1000),
@orgID int
AS
BEGIN
	 IF (Not exists(select Title from Workshop where Title=@Title))
		  BEGIN
				insert into Workshop (Title,WDate,Duration,Presenter,SeatsCount,WLocation,WDescription,orgID)
				  values(@Title,@Date,@Duration,@Presenter,@SeatsCount,@Location,@Description,@orgID)
		  END
END
GO
/****** Object:  StoredProcedure [dbo].[attendance_absent_count_by_workshopID]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* attendance and absent count by workshop ID*/
CREATE proc [dbo].[attendance_absent_count_by_workshopID]
@workshopID int
as 
begin
	IF (exists(select ID from Workshop where ID=@workshopID))
	begin
		SELECT COUNT(ID) AS NumberOfAttendAud FROM Registration where WorkshopID=@workshopID AND Attendance=1 ;
	    SELECT COUNT(ID) AS NumberOfAbsent FROM Registration where WorkshopID=@workshopID AND Attendance=0;
	End
End
GO
/****** Object:  StoredProcedure [dbo].[Attendance_status]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Attendance_status]
@AudID INT,
@WorkshopID INT
as
begin
	IF (exists(select ID from Registration where AudienceID=@AudID AND WorkshopID=@WorkshopID))
	begin
		If((select Attendance from Registration where AudienceID=@AudID AND WorkshopID=@WorkshopID) = 1)
			begin
				update Registration  set Attendance=0  where AudienceID=@AudID AND WorkshopID=@WorkshopID
			end
		else 
			begin
				update Registration  set Attendance=1  where AudienceID=@AudID AND WorkshopID=@WorkshopID
			end
	end
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteAudience]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteAudience]
@ID int
AS
BEGIN
    IF (exists(select ID from Audience where ID=@ID))
        BEGIN
                    delete from Audience where ID=@ID
        END
    ELSE
        BEGIN
                    print 'Invalid ID.'
        END
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrgAdmin]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[DeleteOrgAdmin]
@Id int
AS
BEGIN
	IF (exists(select ID FROM Organaizer_Admin WHERE ID=@Id ))
		BEGIN
		    Delete from Registration WHERE OrganaizerID=id
			Delete from Organaizer_Admin  WHERE ID=@Id
		End
	Else 
		BEGIN
			print 'No Organaize Admin with this ID'
		End
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrgEmployee]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[DeleteOrgEmployee]
@Id int
AS
BEGIN
	IF (exists(select ID FROM Organaizer_Employee WHERE ID=@Id ))
		BEGIN
			Delete from Organaizer_Employee WHERE ID=@Id
		End
	Else 
		BEGIN
			print 'No Organaizer Employee with this ID'
		End
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteRegistration]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteRegistration]
@WorkshopID int,
@audID int 
AS
BEGIN
	If(exists(select ID from Registration where WorkShopID=@WorkshopID AND AudienceID=@audID ) )
		BEGIN
		delete from Registration  where WorkShopID=@WorkshopID AND AudienceID=@audID
		return 1
		END 
	Else
		BEGIN
			return 0
		END
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteWorkshop]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteWorkshop]
@ID int
AS
BEGIN
    IF (exists(select ID from Workshop where ID=@ID))
        BEGIN
            delete from Workshop where ID=@ID
        END
    ELSE
        BEGIN
             print 'Invalid ID.'
        END
END
GO
/****** Object:  StoredProcedure [dbo].[EnrolledWorkshop]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EnrolledWorkshop]
@AudienceID int
as
begin
Select DISTINCT Workshop.Title, Workshop.OrgID, Workshop.Presenter,Workshop.Duration,
Workshop.WDate,Workshop.WDescription,Workshop.WLocation ,Audience.ID ,Workshop.ID AS WID


from Workshop JOIN Registration ON Workshop.ID=Registration.WorkshopID 
Join Audience ON Audience.ID=Registration.AudienceID
WHERE Audience.ID=@AudienceID;
end
GO
/****** Object:  StoredProcedure [dbo].[login_users]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[login_users]
@userEmail varchar(50),
@Password varchar(50),
@Id int out,
@TableNumber int
as
begin
	 if(@TableNumber = 0)
		 begin
			if(exists(select Email from Audience where Email=@userEmail and AudPassword=@Password))
				 begin
					 select @Id= ID from Audience where Email=@userEmail and AudPassword=@Password
				  return @Id
				 end
			else
				 begin
				   return 0
				 end
		 end
	 else 
	 if(@TableNumber = 1)
		 begin
		 	if(exists(select Email from Organaizer_Admin where Email=@userEmail and OrgAdmPassword=@Password))
				 begin
					 select @Id= ID from Organaizer_Admin where Email=@userEmail and OrgAdmPassword=@Password
				  return @Id
				 end
			else
				 begin
				   return 0
				 end
		 end
	 else 
	 if(@TableNumber = 2)
		begin
			if(exists(select Email from Organaizer_Employee where Email=@userEmail and  EmpPassword=@Password))
				 begin
					 select @Id= ID from Organaizer_Employee where Email=@userEmail and  EmpPassword=@Password
				  return @Id
				 end
			else
				 begin
				   return 0
				 end
		end
	 else
		  if(@TableNumber = 3)
			begin
				if(exists(select Email from Admin where Email=@userEmail and UserPassword=@Password))
					 begin
						 select @Id= ID from Admin where Email=@userEmail and UserPassword=@Password
					  return @Id
					 end
				else
					 begin
					   return 0
					 end
			end
	 Else
	 return 0

 
end
GO
/****** Object:  StoredProcedure [dbo].[NewRegistration]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NewRegistration]
@OrgID int,
@WorkshopID int,
@audID int 
AS
BEGIN
     If(NOT exists(select ID from Registration where WorkShopID=@WorkshopID AND AudienceID=@audID ) )
     BEGIN
         IF (not exists(select ID from Workshop where ID=@WorkshopID))
              BEGIN
                       return 0
              END
          Else 
          BEGIN
                IF (not exists(select ID from Organaizer_Admin where ID=@OrgID))
                  BEGIN
                    return 0
                  END
               Else
                   BEGIN
                       IF ( not exists(select ID from Audience where ID=@audID))
                           BEGIN
                             return 0
                           END
                       Else 
                           BEGIN
                                Insert into Registration (WorkShopID,OrganaizerID,AudienceID,Attendance) values (@WorkshopID,@OrgID,@audID,0)
                                 return 1

                           END
                  END 
          END
       END
     Else
         BEGIN
            return 2
         END
END
GO
/****** Object:  StoredProcedure [dbo].[SignUp_Audience]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SignUp_Audience]
@FName varchar(50),
@LName varchar(50),
@Email varchar(100),
@AudPassword varchar(288),
@Phone varchar(50)
as
begin
	 if(exists(select Email from Audience Where Email=@Email and AudPassword=@AudPassword))
		 begin
			  return 0
		 end
	else
		 begin
		     insert into Audience(FName,LName,Email,AudPassword,Phone)
			             values(@FName,@LName,@Email,@AudPassword,@Phone)
		     return 1
		 end
end
GO
/****** Object:  StoredProcedure [dbo].[unEnrolledWorkshop]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[unEnrolledWorkshop]
@AudienceID int
as
begin

SELECT * FROM Workshop ;

end
GO
/****** Object:  StoredProcedure [dbo].[UpdateAudience]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateAudience]
@ID int,
@FName varchar(50),
@LName varchar(50),
@Email varchar(100),
@AudPassword varchar(288),
@Phone varchar(50)
AS
BEGIN
	   IF (exists(select ID from Audience where ID=@ID))
			BEGIN
				update Audience
				set FName=@FName,LName=@LName,Email=@Email,AudPassword=@AudPassword,Phone=@Phone
				where ID=@ID
			END
	   ELSE
		   BEGIN
			 Print 'Invalid ID.'
		   END
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateWorkshop]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------Update Workshop---------------
CREATE proc [dbo].[UpdateWorkshop]
@ID int,
@Title varchar(50),
@Date varchar(100),
@Duration varchar(288),
@Presenter varchar(50),
@SeatsCount varchar(50),
@Location varchar(50),
@Description varchar(1000),
@orgID int
AS
BEGIN
	 IF (exists(select ID from Workshop where ID=@ID))
	 BEGIN
	  update Workshop
	   set Title=@Title,WDate=@Date,Duration=@Duration,Presenter=@Presenter,SeatsCount=@SeatsCount,WLocation=@Location,WDescription=@Description,orgID=@orgID
	   where ID=@ID
	 END
	 ELSE
	 BEGIN
		 print 'Invalid ID.'
	 END
END
GO
/****** Object:  StoredProcedure [dbo].[UpdteEmployeeInfo]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdteEmployeeInfo]
@ID int,
@FName varchar(50),
@LName varchar(50),
@Email varchar(100),
@Password varchar(50),
@Phone varchar(50)
AS
BEGIN
	IF (exists( select ID From Organaizer_Employee where ID=@ID))
		BEGIN
			 update Organaizer_Employee	
			 set FName=@FName,LName=@LName,Email=@Email,Phone=@Phone, EmpPassword=@Password
			 where ID=@ID
		END
	ELSE
	    BEGIN
			print 'No Organaizer Employee with this ID'
		End
END
GO
/****** Object:  StoredProcedure [dbo].[UpdteOrgAdmin]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdteOrgAdmin]
@OrgID int,
@OrgName varchar(50),
@Email varchar(100),
@OrgAdmPassword varchar(288),
@Phone varchar(50)
AS
BEGIN
	IF (exists( select ID From Organaizer_Admin where ID=@OrgID))
		BEGIN
			 update Organaizer_Admin	
			 set OrgName=@OrgName,Email=@Email,OrgAdmPassword=@OrgAdmPassword,Phone=@Phone
			 where ID=@OrgID
		END
	ELSE
	    BEGIN
			print 'No Organaize Admin with this ID'
		End
END
GO
/****** Object:  StoredProcedure [dbo].[UpdteOrgEmployee]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdteOrgEmployee]
@ID int,
@FName varchar(50),
@LName varchar(50),
@Email varchar(100),

@Phone varchar(50),
@OrganizerID int
AS
BEGIN
	IF (exists( select ID From Organaizer_Employee where ID=@ID))
		BEGIN
			 update Organaizer_Employee	
			 set FName=@FName,LName=@LName,Email=@Email,Phone=@Phone, OrganizerID =@OrganizerID
			 where ID=@ID
		END
	ELSE
	    BEGIN
			print 'No Organaizer Employee with this ID'
		End
END
GO
/****** Object:  StoredProcedure [dbo].[UserInfo]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UserInfo]
@Id int out,
@TableNumber int
as
begin
	  if(@TableNumber = 0)
			begin
				if(exists(select Id  from Audience where ID=@Id))
					 begin
						 select * from Audience  where ID=@Id
					 end
				else
					 begin
					   return 0
					 end
			end
	 else 
	 if(@TableNumber = 1)
		 begin
		 	if(exists(select Id  from Organaizer_Admin where ID=@Id))
				 begin
					 select * from Organaizer_Admin  where ID=@Id
				 end
			else
				 begin
				   return 0
				 end
		 end
	 else 
	 if(@TableNumber = 2)
		begin
			if(exists(select Id  from Organaizer_Employee  where ID=@Id))
				 begin
					 select * from Organaizer_Employee  where ID=@Id
				 end
			else
				 begin
				   return 0
				 end
		end
	 else
		  if(@TableNumber = 3)
			begin
				if(exists(select Id  from Admin where ID=@Id))
					 begin
						 select * from Admin  where ID=@Id
					 end
				else
					 begin
					   return 0
					 end
			end
	 Else
	 return 0
end
GO
/****** Object:  StoredProcedure [dbo].[Workshop_Count_by_Orgnizer]    Script Date: 17/08/42 01:58:04 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Workshop_Count_by_Orgnizer]
@OrgID int
as 
begin
	IF (exists(select ID from Organaizer_Admin where ID=@OrgID))
	begin
		SELECT COUNT(ID) AS NumberOfworkshop FROM Workshop where OrgID=@OrgID ;
	    SELECT * FROM Workshop where OrgID=@OrgID ;
	End
End
GO
