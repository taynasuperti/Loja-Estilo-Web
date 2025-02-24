USE lojinha;
GO

-- Comandos DML - Data Manipulation Language
-- Inserir Dados
INSERT INTO Categoria(Nome, ExibirHome) VALUES
('Assistentes', 1), -- categoria 1
('Cadeiras', 1), -- categoria 2
('Fones', 1), -- categoria 3
('Leds', 0), -- categoria 4
('Mesas', 1), -- categoria 5
('Monitores', 1), -- categoria 6
('Mouses', 1), -- categoria 7
('Mouse pad', 0), -- categoria 8
('Relógios', 0), -- categoria 9
('Caixas de Som', 1), -- categoria 10
('Suportes para Monitor', 0), -- categoria 11
('Suportes para Notbook', 0), -- categoria 12
('Suportes de pulso', 0), --categoria 13
('Teclados', 1), -- categoria 14
('Umidificador', 0), -- categoria 15
('Webcam', 0); -- categoria 16

-- Mesas
INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES 
('Mesa Kuadra 150cm', 'Mesa para Escritório Diretor Estilo Industrial 150cm Kuadra',
20, 301.00, 420.00, 1, 5);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES  
('Mesa Para Computador Gamer Rubi 156 cm', 'Mesa Para Computador Gamer Rubi - Branco - 156 cm',
320.00, 420.00, 0, 5);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES 
('Mesa Gamer e Escritório XT Racer Space One', 'Mesa Gamer e Escritório XT Racer Space One',
529.98, 566.98, 1, 5);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Escrivaninha Em L Max Zanzini', 'Escrivaninha Em L Max Zanzini',
249.00, 349.00, 0, 5);

-- Mouse pads
INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse pad de carregamento sem fio Firelison 2 em 1', 'Mouse Pad Firelison 2 em 1',
310.90, 411.78, 0, 8);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse Pad Gamer Criarte, Speed Extra Grande, Abstract Premium, Preto E Branco - 70x30 Cm',
'Mouse Pad Gamer Criarte', 35.90, 55.90, 0, 8);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mousepad Techsource - Topo Black V2', 'Mousepad Techsource V2',
160.50, 178.54, 0, 8);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse Pad Corsair MM700 3XL RGB', 'Mouse Pad Corsair MM700 3XL RGB',
650.00, 759.20, 0, 8);

-- Monitores

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Monitor MSI Pro MP241CAW 24 FHD 75Hz Curvo VA Branco', 'Monitor MSI Pro MP241CAW 24',
2764.00, 2564.00, 1, 6);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Monitor Gamer Curvo 30 MSI Optix MAG301CR / HDMI x2 / DP / WFHD / 200Hz / 1ms / HDR / MSI RGB Mystic Light',
'Monitor MSI MAG301CR 30 200Hz', 6999.99, 7499.99, 0, 6);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Monitor GameMax Gamer Curvo 27 Pol 144Hz 1ms Full HD GMX27C144 Branco - Open Box',
'Monitor GameMax GMX27C144 27', 1000.00, 1359.32, 1, 6);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Monitor curvo de 34 com tecnologia QD-OLED e AMD FreeSync™ Premium Pro', 'Monitor 34'' Curvo QD-OLED, FreeSync Pro',
6000.00, 6289.15, 0, 6);

-- Suporte para monitores

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte de monitor Armstrong DUO Branco - Elements', 'Suporte de Monitor Armstrong DUO Branco',
590.95, 849.00, 0, 11);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte De Mesa Duplo Com Pistão A Gás 14 À 32'' Sim-2500 Cor Preto', 
'Suporte Duplo de Mesa SIM-2500, 14''-32''', 200.55, 295.99, 0, 11);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte Articulado Com Pistao a Gas Para Monitor Zinnia Nimbo 100, 17 Pol. a 27 Pol., Branco, ZNO-ZNNBO100-WH01',
'Suporte Articulado Zinnia Nimbo 100', 100.99, 129.99, 0, 11);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte Para Monitor De Parede A Gás 17 A 32 Articulado Vesa Cor Preto',
'Suporte Articulado 17''-32'' VESA', 250.85, 279.99, 0, 11);

-- Suporte para notebooks 

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte Dobrável Ergonômico Portátil Slim Para Notebook Tablet Ajustável Luuk Young S50 Prateado',
'Suporte Ergonômico Dobrável Luuk Young S50 Prateado', 20.00, 24,11, 0, 12);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte Mesa Base Notebook Alumínio Regulável Leitura Cor Preto', 'Suporte Regulável de Alumínio para Notebook',
65.85, 79.53, 0, 12);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte Notebook Aluminio Regulavel Base Giratoria 360º', 'Suporte Regulável de Alumínio para Notebook com Base Giratória 360º', 
95.75, 115.99, 0, 12);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Base Suporte Ergonômico Para Notebook Tablet Dobrável top - Home Good', 'Suporte Ergonômica Home Goods',
42.75, 50.15, 0, 12);

-- Led para monitores

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Barra de LED para Monitor Pcyes PLMLCB01, 447x85mm, Regulagem Touch, USB, Preto - 111552',
'Barra de LED Pcyes', 125.45, 169.90, 0, 4);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Light Bar, Preto, RGB Lightbar, Light Bar Monitor com Tres temperaturas de cor 15 cores modo, Luz Monitor, Led Monitor Light Bar, Barra de Luz para Monitor, Lightbar Monitor, Luminaria Monitor',
'Led para monitor, com três temperaturas de cor e 15 modos de cor', 175.99, 189.99, 1, 4);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Bases Luminária Led Monitor E Notebooks Regulável Cor Preta', 'Led para Monitor E Notebooks Regulável',
259.65, 289.99, 0, 4);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Gugxiom Barra de luz curvada para monitor, lâmpada de monitor de computador, barra de LED para monitor de PC com 3 ajustes de temperatura de cor e 7 cores RGB, luz de monitor óptico assimétrica de 5V',
'Barra de Luz LED Curva para Monitor com 3 temperaturas de cor e 7 cores RGB', 259.69, 278.10, 0, 4);

-- Webcam

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Web cam aicoco 2k Web Cam Com Microfone Ai Auto Ac610', 'Webcam Aicoco 2K', 
489.99, 584.10, 0, 16);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Webcam Philips SPL6208 1080P com microfone para streaming de PC', 'Webcam Philips com microfone', 
398.33, 438.33, 0, 16);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Logitech StreamCam Webcam USB-C Full HD Blanca', 'Webcam USB-C Full HD Branca', 
598.99, 658.96, 0, 16);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('1080p Full Hd Usb Webcam Para PC Desktop Laptop Web Camera Com Microfone Fhd - HUOGUO',
'Webcam 1080p Full HD com microfone - HUOGUO', 320.95, 375.00, 0, 16);

-- Teclado

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('TECLADO EPOMAKER RT100', 'TECLADO EPOMAKER RT100', 
495.89, 554.22, 1, 14);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Attack Shark Ajazz AK820 Teclado mecânico para jogos com botão 75% teclado Hot Swappable Tipo-C com fio junta com 5 camadas de espuma absorvente de ruído branco LED retroiluminado NKRO interruptor',
'Teclado mecânico Attack Shark Ajazz AK820 com LED branco e NKRO', 299.90, 349.00, 0, 14);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Teclado Gamer Semi - Mecânico Rise Mode G1 Rgb Ptbr (Branco)', 'Teclado Gamer Semi - Mecânico',
49.90, 69.90, 0, 14);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('TECLADO EPOMAKER RT100', 'TECLADO EPOMAKER RT100',
579.99, 629.22, 1, 14);

-- Mouses 

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse Gamer Sem Fio Logitech G PRO X SUPERLIGHT 2 com LIGHTSPEED e Bateria Recarregável', 
'Mouse Logitech G PRO X SUPERLIGHT 2', 800.75, 847.71, 1, 7);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse Gamer X6 Attack Shark Tri Mode 26000dpi Paw3395 + Dock Cor Preto', 'Mouse Gamer X6 Attack Shark',
199.90, 240,00, 0, 7);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse Gamer X11 Attack Shark Tri Mode 22000dpi Paw3311 Dock Cor Branco', 'Mouse Gamer X11 Attack Shark',
189.99, 250.00, 7);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Mouse Gamer Sem Fio Logitech G PRO Wireless LIGHTSPEED RGB', 'Mouse Logitech G PRO Wireless LIGHTSPEED RGB',
500.99, 550.00, 1, 7);

-- Fones

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Headtset Gamer Redragon Zeus Pro, Surround 7.1, Cabo USB-C Removível, Wireless, c/Microfone, Preto - H510-PRO', 
'Headset Redragon Zeus Pro', 415.00, 430.00, 1, 3);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('HAVIT Fone de Ouvido Headset Gamer FUXI-H3 Quad-Mode (com fio e sem fio, Wireless 2,4GHz, Bluetooth, Cabo USB-C, Cabo Auxiliar 3.5mm). Surround, Baixa Latência - Preto',
'Fone gamer HAVIT FUXI-H3, quad-mode, Bluetooth, 2,4GHz, USB-C, 3.5mm', 199.99, 250.00, 0, 3);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('2.4ghz Gaming Headset Para Pc,ps4,ps5,mac,nintendo Switch', 'Headset 2.4GHz para PC, PS4, PS5, Mac e Nintendo Switch', 
300.00, 338.90, 0, 3);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Headset Gamer Sem Fio Quantum 350 Para Pc Drivers 40mm Jbl Cor Preto', 'Headset gamer sem fio JBL Quantum 350, drivers 40mm', 
329.99, 379.99, 1, 3);

-- Caixa de som 

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Caixa de som Gamer G2000 Bluetooth 16W RMS EDIFIER - Branco', 'Caixa de Som EDIFIER G2000',
415.55, 449.19, 1, 10);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('HP Caixa de som 2.1 DHS-2111S Preta Speaker com Alimentacao USB e conector 3.5mm potência do Subwoofer 5W 2B285AA',
'Caixa de Som 2.1 Speaker', 129.90, 169.90, 0, 10);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('BESTISAN Bluetooth Bookshelf RCA Speakers for Record Player, Turntable Speaker with 4 inch Woofer, Optical/RCA Inputs for PC and TV, White, Pair, SR06',
'Caixa de Som BESTISAN SR0', 345.95, 377.94, 1, 10);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Bestisan SR04 Bluetooth Bookshelf Speakers for Record Player, Powered Studio Speaker for TV with Sub Out Port, Horn Tweeter and Optical/RCA/BT Inputs',
'Caixa de Som BESTISAN SR04', 390.49, 427.62, 0, 10);

-- Suporte de pulso 

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte de pulso ergonômico para teclado em formato de nuvem', 'Suporte de Pulso Nuvem',
295.89, 320.00, 0, 13);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Apoio De Pulso Multilaser Para Teclado Em Gel Preto - Ac033 Desenho impresso Liso 51cm de comprimento e 6cm de largura, 2cm de altura',
'Suporte de pulso Multilaser - Ac033', 25.90, 37.99, 0, 13);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Bloss Almofada de mesa de couro e descanso de pulso para teclado, mouse pad grande + teclado + suporte de pulso para mouse, protetor de mesa antiderrapante para escritório, casa (80 x 40 cm, bege)',
'Suporte de Pulso e Mouse Pad', 195.85, 214.75, 0, 13);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Suporte de descanso de pulso para teclado e mouse, com espuma de memória ergonômica, base antiderrapante para escritório doméstico, laptop, desktop',
'Suporte de pulso ergonômico', 15.90, 25.95, 0, 13);

-- Assistentes

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Eilik Robô - Robô Inteligente', 'Eilik Robô', 
1250.00, 1539.10, 1, 1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Echo Dot 5ª geração Amazon, com Alexa, Smart Speaker, Preto - B09B8VGCR8', 'Alexa Echo Dot 5ª geração', 
420.99, 489.99, 0, 1);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Echo Pop Amazon, com Alexa, Smart Speaker, Som Envolvente, Branco - B09ZXN77L2', 'Alexa Echo Pop Amazon',
415.89, 499.99, 1, 1);


INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Alexa Echo Dot Geração Alexa Smart Speaker Wi-Fi - Amazon', 'Alexa Echo Dot 3ª Geração - Amazon',
1250.00, 1345.94, 0, 1);

-- Relógios

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Relógio Digital 3D LED De Parede e Mesa Design Moderno Luz Noturna Decoração', 'Relógio Digital 3D LED',
25.00, 40.00, 0, 9);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Relógio despertador digital, Relógio LED para quarto, Relógio eletrônico de mesa com visor de temperatura, brilho ajustável, controle de voz, visor 12/24H para casa, dormitório, escritório',
'Relógio LED Digital', 45.99, 52.90, 0, 9);

-- Umidificadores

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Umidificador em forma de nuvem com suporte dourado', 'Umidificador Nuvem',
189.99, 285.00, 0, 9);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Umidificador Ar Aromatizador Purificador Portátil Led 500ml', 'Umidificador Led 500ml', 
65.90, 78.99, 0, 9);

-- Cadeiras

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Cadeira Gamer Flexform Delta White N Blue', 'Cadeira Gamer Flexform Delta',
1299.99, 1457.19, 0, 2);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Cadeira Gamer Flexform Alpha 2 Pro Black', 'Cadeira Gamer Flexform Alpha Pro',
2999.99, 3509.10, 1, 2);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Cadeira Gamer Home Office Branca com Rosa Claro', 'Cadeira Gamer Branca com Rosa Claro',
2899.99, 3509.10, 1, 2);

INSERT INTO Produto(Nome, Descricao, QtdeEstoque, ValorCusto, ValorVenda, Destaque, CategoriaId)
VALUES ('Cadeira Gamer XT Racer Viking Series, Até 120 Kg, Com Almofadas, Reclinável, Descanso de Braço 3D, Preto - XTR-014o',
'Cadeira Gamer XT Racer Viking Series', 599.90, 899.99, 0, 2);
