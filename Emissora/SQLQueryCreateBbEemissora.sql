Create DataBase Emissora;

Use [Emissora];

Create Table dbo.Usuarios (
                    id int identity (1,1) not null,
                    Nome varchar(100) not null,
                    Cpf int not null,
                    Login varchar(30) not null,
                    Senha varchar(30) not null,
                    TipoPerfil int not null,
                    Cache float not null,
                    GeneroObra int not null,
                    DataDisponibilidade DateTime not null,
                    Cidade varchar(100) not null,
                    Estado varchar(10) not null,
                    Cep int not null,
                    DataCadastro DateTime not null
                    )

	Alter Table dbo.Usuarios
	Add CONSTRAINT PK_Usuarios_ID PRIMARY KEY NONCLUSTERED (id);

	Create Table dbo.Elenco (
                    id int identity (1,1) not null,
                    idAtor int not null,
                    idObra int not null
                    )
	Alter Table dbo.Elenco
	Add CONSTRAINT PK_Elenco_ID PRIMARY KEY NONCLUSTERED (id);

	Create Table dbo.Obra (
                    id int identity (1,1) not null,
                    Titulo int not null,
                    idGenero int not null,
					Orcamento float not null,
					dataInicio DateTime not null,
					dataFim DateTime not null,
                    )

	Alter Table dbo.Obra
	Add CONSTRAINT PK_Obra_ID PRIMARY KEY NONCLUSTERED (id);

	Create Table dbo.Genero (
                id int identity (1,1) not null,
                Genero int not null
                )
	Alter Table dbo.Genero
	Add CONSTRAINT PK_Genero_ID PRIMARY KEY NONCLUSTERED (id);

