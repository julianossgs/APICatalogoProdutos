create database ApiCatalogoDB
go

use APICatalogoDB
go

create table TblProduto
(ProdutoId int primary key identity,
 Nome varchar(30),
 Descricao varchar(60),
 Preco decimal(10,2),
 DataCadastro datetime)
 go

 insert into TblProduto
 values('Skol','Lata 350ml',6.90,'18/07/2022')
 go


 create table TblVenda
 (VendasId int primary key identity,
  DataVenda datetime,
  Dia varchar(5),
  Desconto float,
  Produto_Id int)
  go

  insert into TblVenda
  values('18/07/2022','18',7,1)
  go


  alter table TblVenda add constraint FK_Venda_Produto
  foreign key(Produto_Id) references TblProduto(ProdutoId)
  go

  select * from TblVenda
  go
