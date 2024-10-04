create proc StudentCer
@id varchar(50)
as
SELECT [idCard]
      ,[Fname]
      ,[Lname]
      ,[FnameFR]
      ,[LnameFR]
      ,[DateBirth]
      ,[PlaceBirth]
      ,[CityBith]
      ,[Univ]
      ,[Fac]
      ,[majal]
      ,[UnivPhase]
      ,[UnivFiliere]
      ,[UnivLevel]
      ,[UnivSpecialty]
  FROM [dbo].[NewStudentsFirstYear]
  where idCard=@id




