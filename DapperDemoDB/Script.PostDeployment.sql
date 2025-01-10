if not exists (select 1 from dbo.[User])
begin
    insert into dbo.[User] (Id, FirstName, LastName)
    values ('83e9d0a4-d39a-4e71-b594-5c3e5d8d7fa3', 'Tim','Corey'),
    ('d34f7422-00f8-452b-b1a5-68127e98b23b','Sophia','Martinez');
end 