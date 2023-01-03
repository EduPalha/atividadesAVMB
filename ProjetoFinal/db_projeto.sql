create database db_projeto;

create table accounts
(
	id integer identity primary key,
    software varchar(40),
    login varchar(50),
    password varchar(256),
    lastDate datetime
);

insert into accounts values ('microsoft', 'edupalharini95', 'senha1234*', getdate());

create login eduardo with password='senha123*';
create user eduardo from login eduardo;
exec sp_addrolemember 'DB_DATAREADER', 'eduardo';
exec sp_addrolemember 'DB_DATAWRITER', 'eduardo';