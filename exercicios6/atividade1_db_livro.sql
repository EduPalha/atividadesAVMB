create table autor
(
	idAutor Serial Constraint pk_idAutor Primary Key,
	nome varchar(50),
	nacionalidade varchar(30)
)


create table livro
(
	idLivro Serial Constraint pk_idLivro Primary Key,
	isbn bigint,
	ano_publicacao integer,
	fk_idEditora integer,
	fk_idCategoria integer,
	FOREIGN KEY (fk_idEditora) REFERENCES EDITORA(idEditora),
	FOREIGN KEY (fk_idCategoria) REFERENCES CATEGORIA(idCategoria)
)
alter table livro add titulo varchar(80)

create table livro_autor
(
	idLivroAutor Serial Constraint pk_idLivroAutor Primary Key,
	fk_idLivro integer,
	fk_idAutor integer,
	FOREIGN KEY (fk_idLivro) REFERENCES LIVRO(idLivro),
	FOREIGN KEY (fk_idAutor) REFERENCES AUTOR(idAutor)
)

create table editora
(
	idEditora Serial Constraint pk_idEditora Primary Key,
	nome varchar(50)
)

create table categoria
(
	idCategoria Serial Constraint pk_idCategoria Primary Key,
	tipo_categoria varchar(20)
)

insert into autor(nome, nacionalidade) values('J. K. ROWLING', 'INGLATERRA');
insert into autor(nome, nacionalidade) values('CLIVE STAPLES LEWIS', 'INGLATERRA');
insert into autor(nome, nacionalidade) values('AFFONSO SOLANO', 'BRASIL');
insert into autor(nome, nacionalidade) values('MARCOS PIANGERS', 'BRASIL');
insert into autor(nome, nacionalidade) values('CIRO BOTELHO (TIRIRICA)', 'BRASIL');
insert into autor(nome, nacionalidade) values('BIANCA MÓL', 'BRASIL');


insert into livro_autor(fk_idLivro, fk_idAutor) values (1,1);
insert into livro_autor(fk_idLivro, fk_idAutor) values (2,2);
insert into livro_autor(fk_idLivro, fk_idAutor) values (3,3);
insert into livro_autor(fk_idLivro, fk_idAutor) values (4,4);
insert into livro_autor(fk_idLivro, fk_idAutor) values (5,5);
insert into livro_autor(fk_idLivro, fk_idAutor) values (6,6);
insert into livro_autor(fk_idLivro, fk_idAutor) values (7,1);


insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('HARRY POTTER E A PEDRA FILOSOFAL', 8532511015, 2000, 1, 1);
insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('AS CRÔNICAS DE NÁRNIA', 9788578270698, 2009, 2, 1);
insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('O ESPADACHIM DE CARVÃO', 9788577343348, 2013, 3, 2);
insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('O PAPAI É POP', 9788581742458, 2015, 4, 3);
insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('PIOR QUE TÁ NÃO FICA', 9788582302026, 2015, 5, 3);
insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('GAROTA DESDOBRÁVEL', 9788577345670, 2015, 3, 1);
insert into livro(titulo, isbn, ano_publicacao, fk_idEditora, fk_idCategoria) values ('HARRY POTTER E O PRISIONEIRO DE AZKABAN', 8532512062, 2000, 1, 1);


insert into editora(nome) values ('ROCCO');
insert into editora(nome) values ('WMF MARTINS FONTES');
insert into editora(nome) values ('CASA DA PALAVRA');
insert into editora(nome) values ('BELAS LETRAS');
insert into editora(nome) values ('MATRIX');


insert into categoria(tipo_categoria) values ('LITERATURA JUVENIL');
insert into categoria(tipo_categoria) values ('FICÇÃO CIENTÍFICA');
insert into categoria(tipo_categoria) values ('HUMOR');


/*	7. */
select li.isbn, li.titulo, li.ano_publicacao, ed.nome, au.nome, au.nacionalidade, cat.tipo_categoria
from livro as li
inner join livro_autor as la on la.fk_idLivro = li.idLivro
inner join autor as au on au.idAutor = la.fk_idAutor
inner join editora as ed on ed.idEditora = li.fk_idEditora
inner join categoria as cat on cat.idCategoria = li.fk_idCategoria
order by li.titulo asc;

/*	8. */
select au.nome, li.titulo 
from autor au
inner join livro_autor as la on la.fk_idAutor = au.idAutor
inner join livro as li on li.idLivro = la.fk_idLivro
order by au.nome asc;

/*	9 */
select li.isbn, li.ano_publicacao, li.titulo, au.nome, ed.nome
from categoria cat
inner join livro as li on li.fk_idCategoria = cat.idCategoria
inner join editora as ed on ed.idEditora = li.fk_idEditora
inner join livro_autor as la on la.fk_idLivro = li.idLivro
inner join autor as au on au.idAutor = la.fk_idAutor
where cat.tipo_categoria = 'LITERATURA JUVENIL'
order by li.ano_publicacao asc;

/*	10 */
select li.isbn, li.ano_publicacao, li.titulo, au.nome, ed.nome
from categoria cat
inner join livro as li on li.fk_idCategoria = cat.idCategoria
inner join editora as ed on ed.idEditora = li.fk_idEditora
inner join livro_autor as la on la.fk_idLivro = li.idLivro
inner join autor as au on au.idAutor = la.fk_idAutor
where (cat.tipo_categoria = 'FICÇÃO CIENTÍFICA' or cat.tipo_categoria = 'HUMOR')
and (li.ano_publicacao >= 2010 and li.ano_publicacao <= 2020) 
order by li.ano_publicacao asc;


