Create proc AddS1
@idCardS varchar(50),
@FnameS varchar(50),
@LnameS varchar(50),
@FnameFRS varchar(50),
@LnameFRS varchar(50),
@DateBirthS date,
@PlaceBirthS varchar(50),
@CityBithS varchar(50),
@GenderS varchar(50)
as
insert into test(idCard ,Fname,Lname,FnameFR,LnameFR,DateBirth,PlaceBirth,CityBith,Gender)
values
(@idCardS ,@FnameS,@LnameS ,@FnameFRS ,@LnameFRS ,@DateBirthS ,@PlaceBirthS ,@CityBithS ,@GenderS)