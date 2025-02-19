USE lojinha;
GO

-- Comandos DML - Data Manipulation Language
-- Inserir Dados
INSERT INTO Categoria(Nome, ExibirHome) VALUES
('Assistentes', 1),
('Cadeiras', 1),
('Fones', 1),
('Leds', 0), 
('Mesas', 0),
('Monitores', 1),
('Mouses', 1),
('Mouse pad', 0),
('Relógios', 0),
('Caixas de Som', 1),
('Suportes para Monitor', 1),
('Suportes para Notbook', 0),
('Suportes de pulso', 0),
('Teclados', 1),
('Umidificador', 0),
('Webcam', 0);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES 
('Mesa Kuadra 150cm', 'Mesa para Escritório Diretor Estilo Industrial 150cm Kuadra',
20, 301.00, 420.00, 0, 5);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES  
('Mesa Para Computador Gamer Rubi 156 cm', 'Mesa Para Computador Gamer Rubi - Branco - 156 cm',
320.00, 420.00, 1, 5);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES 
('Mesa Gamer e Escritório XT Racer Space One', 'Mesa Gamer e Escritório XT Racer Space One',
529.98, 566.98, 0, 5);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Escrivaninha Em L Max Zanzini', 'Escrivaninha Em L Max Zanzini',
249.00, 349.00, 0, 5);

