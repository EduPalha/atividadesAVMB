create table cliente
(
	idCliente Serial Constraint pk_idCliente Primary Key,
	nome varchar(80),
	rg bigint,
	telefone bigint,
	endereco varchar(80),
	cep integer
)

create table produto
(
	idProduto Serial Constraint pk_idProduto Primary Key,
	nome varchar(50),
	tipo_produto varchar(20),
	preco decimal(9,2),
	qtd integer,
	descAdicional varchar(80)
)

create table pedido
(
	idPedido Serial Constraint pk_idPedido Primary Key,
	dataPedido date,
	horaPedido time,
	subtotal decimal(9,2)
)

create table pedido_produto
(
	preco decimal(9,2),
	qtd integer,
	subtotal decimal(9,2),
	fk_idPedido integer,
	fk_idProduto integer,
	FOREIGN KEY (fk_idPedido) REFERENCES PEDIDO(idPedido),
	FOREIGN KEY (fk_idProduto) REFERENCES PRODUTO(idProduto)
)

create table venda
(
	idVenda Serial Constraint pk_idVenda Primary Key,
	dataVenda date,
	horaVenda time,
	fk_idPedido integer,
	FOREIGN KEY (fk_idPedido) REFERENCES PEDIDO(idPedido)
)