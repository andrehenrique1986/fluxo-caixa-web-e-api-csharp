USE [DB_FLUXO_CAIXA]
GO

SELECT * FROM Categoria

INSERT INTO Categoria VALUES ('Receitas')
INSERT INTO Categoria VALUES ('Moradia')
INSERT INTO Categoria VALUES ('Transporte')
INSERT INTO Categoria VALUES ('Alimenta��o')
INSERT INTO Categoria VALUES ('Sa�de')
INSERT INTO Categoria VALUES ('Educa��o')
INSERT INTO Categoria VALUES ('Lazer')
INSERT INTO Categoria VALUES ('D�vidas')



select * from Subcategoria

SELECT * FROM Custo

INSERT INTO Custo VALUES (0)
INSERT INTO Custo VALUES (1)

SELECT * FROM Fluxo

INSERT INTO Fluxo VALUES (0)
INSERT INTO Fluxo VALUES (1)


SELECT * FROM FormaDePagamento

INSERT INTO FormaDePagamento VALUES ('Cart�o de Cr�dito')
INSERT INTO FormaDePagamento VALUES ('PIX')
INSERT INTO FormaDePagamento VALUES ('Boleto')
INSERT INTO FormaDePagamento VALUES ('D�bito')


select Subcategoria.IdSubcategoria, Subcategoria.DscTipoSubcategoria,Categoria.DscTipoCategoria from Subcategoria 
INNER JOIN Categoria 
ON Subcategoria.IdCategoria = Categoria.IdCategoria

INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES ('Sal�rio',1,1);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Investimento',1,1);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Vendas',1,1);


INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES ('Aluguel',2,2);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Condom�nio',2,2);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Luz',2,2);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Manuten��o',2,2);

INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Gasolina',3,3);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Manuten��o Carro',3,3);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Seguro',3,3);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Impostos e Multas',3,3);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Uber',3,3);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('�nibus',3,3);

INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Supermercado',4,4);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Pizzaria',4,4);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Jantar Fora',4,4);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Lanches',4,4);

INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Consultas',5,5);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Exames',5,5);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Plano de Sa�de',5,5);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Rem�dios',5,5);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Academia',5,5);

INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Escola',6,6);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Universidade',6,6);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Material Escolar',6,6);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Cursos',6,6);


INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Cinema',7,7);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Restaurante',7,7);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Viagens',7,7);
INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Shows',7,7);

INSERT INTO [dbo].[Subcategoria]([DscTipoSubcategoria],[IdCategoria],[CategoriaIdCategoria]) VALUES('Empr�stimo',8,8);