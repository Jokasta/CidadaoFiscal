Create Database CIDADAO_FISCAL
GO

USE CIDADAO_FISCAL
GO

Create Table Usuario(
	ID uniqueidentifier,
	Nome_Completo varchar(100) not null,
	Data_Nascimento date not null,
	Sexo char(1) not null,
	RG varchar(11) not null,
	CPF varchar(11) not null,
	Email varchar(100) not null,
	Login varchar(100) not null,
	Senha varchar(20) not null,
	Status bit not null,--MAPEAR ATÉ AQUI
	Constraint Pk_UsuarioId Primary Key nonclustered(ID),
	Constraint U_Email Unique nonclustered(Email),
)
GO

Create Table Endereco(
	ID uniqueidentifier,
	Rua varchar(255) not null,
	Numero_Casa int not null,
	Bairro varchar(100) not null,
	Cidade varchar(80) not null,
	CEP varchar(8) not null,
	Sigla_Estado varchar(2) not null,--MAPEAR ATÉ AQUI
	Usuario_ID uniqueidentifier not null,
	Constraint Pk_EnderecoId Primary Key nonclustered(ID),
	Constraint Fk_Endereco_UsuarioId Foreign Key (Usuario_ID) references Usuario(ID),
)
GO
			
Create Table Denuncia(
	ID uniqueidentifier,
	Data_Hora date not null,
	Rua varchar(255) not null,
	Bairro varchar(100) not null,
	Cidade varchar(80) not null,
	Sigla_Estado varchar(2) not null,
	CEP varchar(8) not null,
	Categoria_Denuncia varchar(15)not null,
	Descricao varchar(200),
	Status bit not null,--MAPEAR ATÉ AQUI
	Usuario_ID uniqueidentifier not null,
	Constraint Pk_DenunciaId Primary Key nonclustered(ID),
	Constraint Fk_Denuncia_UsuarioId Foreign Key (Usuario_ID) references Usuario(ID),
)
GO
