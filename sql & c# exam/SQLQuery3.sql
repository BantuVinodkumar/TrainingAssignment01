create database vinod3
use vinod3

Declare @dateofbirth datetime
Declare @currentdatetime datetime
Declare @years varchar(4)
set @dateofbirth = '1999-03-15' --Birthdate
set @currentdatetime = getdate() --Current Datetime
select @years = datediff(year,@dateofbirth,@currentdatetime)
select @years + ' years,' as years