using LojaEstiloWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaEstiloWeb.Data;
    public class AppDbSeed
    {
        public AppDbSeed(ModelBuilder builder)
        {
            List<Categoria> categorias = new() {
                new() {Id = 1, Nome = "Assistentes", Foto = "img/categorias/assistente/eilik-1.jpg"},
                new() {Id = 2, Nome = "Cadeiras", Foto = "img/categorias/cadeira/cadeira-2.jpg"},
                new() {Id = 3, Nome = "Fones", Foto = "img/categorias/fone/fone-2.webp"},
                new() {Id = 4, Nome = "Leds", Foto = "img/categorias/led/led-monitor-2.jpg"},
                new() {Id = 5, Nome = "Mesas", Foto = "img/categorias/mesa/mesa-gamer-1.jpg"},
                new() {Id = 6, Nome = "Monitores", Foto = "img/categorias/monitor/monitor-1.webp"},
                new() {Id = 7, Nome = "Mouses", Foto = "img/categorias/mouse/mouse-5.jpg"},
                new() {Id = 8, Nome = "Mouse pad", Foto = "img/categorias/mouse-pad/mousepad-3.jpg"},
                new() {Id = 9, Nome = "Relógios", Foto = "img/categorias/relogio/relogio-2.jpeg"},
                new() {Id = 10, Nome = "Caixas de Som", Foto = "img/categorias/som/caixa-de-som-2.jpeg"},
                new() {Id = 11, Nome = "Suportes para Monitor", Foto = "img/categorias/suporte/suporte-monitor-3.jpg"},
                new() {Id = 12, Nome = "Suportes para Notbook", Foto = "img/categorias/suporte-notbook/suporte-2.jpeg"},
                new() {Id = 13, Nome = "Suportes de pulso", Foto = "img/categorias/suporte-pulso/apoio-de-pulso.jpg"},
                new() {Id = 14, Nome = "Teclados", Foto = "img/categorias/teclado/teclado-customizavel-1.jpg"},
                new() {Id = 15, Nome = "Umidificador", Foto = "img/categorias/umidificador/difusor-2.webp"},
                new() {Id = 16, Nome = "Webcam", Foto = "img/categorias/webcam/web-cam-1.jpg"},
            };
            builder.Entity<Categoria>().HasData(categorias);

            List<Produto> produtos = new() {
                //mesas
                new() {
                    Id = 1,
                    CategoriaId = 5,
                    Nome = "Mesa Kuadra",
                    Descricao = "Mesa para Escritório Diretor Estilo Industrial 150cm Kuadra",
                    ValorCusto = 301.00m,
                    ValorVenda = 420.00m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 2,
                    CategoriaId = 5,
                    Nome = "Mesa Gamer Para Computador Rubi",
                    Descricao = "Mesa Para Computador Gamer Rubi - Branca - 156 cm",
                    ValorCusto = 320.00m,
                    ValorVenda = 420.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 3,
                    CategoriaId = 5,
                    Nome = "Mesa Gamer XT Racer Space One",
                    Descricao = "Mesa Gamer e Escritório XT Racer Space One",
                    ValorCusto = 529.98m,
                    ValorVenda = 566.98m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 4,
                    CategoriaId = 5,
                    Nome = "Escrivaninha Max Zanzini",
                    Descricao = "Escrivaninha Em L Max Zanzini",
                    ValorCusto = 249.00m,
                    ValorVenda = 411.78m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //mouse pads
                new() {
                    Id = 5,
                    CategoriaId = 8,
                    Nome = "Mouse pad Firelison de carregamento sem fio",
                    Descricao = "Mouse pad de carregamento sem fio Firelison 2 em 1",
                    ValorCusto = 310.90m,
                    ValorVenda = 411.78m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 6,
                    CategoriaId = 8,
                    Nome = "Mouse Pad Gamer Criarte",
                    Descricao = "Mouse Pad Gamer Criarte, Speed Extra Grande, Abstract Premium, Preto E Branco - 70x30 Cm",
                    ValorCusto = 35.90m,
                    ValorVenda = 55.90m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 7,
                    CategoriaId = 8,
                    Nome = "Mousepad Techsource Black V2",
                    Descricao = "Mousepad Techsource - Topo Black V2",
                    ValorCusto = 160.50m,
                    ValorVenda = 178.54m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 8,
                    CategoriaId = 8,
                    Nome = "Mouse Pad Corsair",
                    Descricao = "Mouse Pad Corsair MM700 3XL RGB",
                    ValorCusto = 650.00m,
                    ValorVenda = 759.20m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //monitores
                new() {
                    Id = 9,
                    CategoriaId = 6,
                    Nome = "Monitor MSI Pro MP241CAW 24 75Hz",
                    Descricao = "Monitor MSI Pro MP241CAW 24 FHD 75Hz Curvo VA Branco",
                    ValorCusto = 2764.00m,
                    ValorVenda = 2564.00m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 10,
                    CategoriaId = 6,
                    Nome = "Monitor MSI MAG301CR 30 200Hz",
                    Descricao = "Monitor Gamer Curvo 30 MSI Optix MAG301CR / HDMI x2 / DP / WFHD / 200Hz / 1ms / HDR / MSI RGB Mystic Light",
                    ValorCusto = 6999.99m,
                    ValorVenda = 7499.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 11,
                    CategoriaId = 6,
                    Nome = "Monitor GameMax GMX27C144 27 144Hz",
                    Descricao = "Monitor GameMax Gamer Curvo 27 Pol 144Hz 1ms Full HD GMX27C144 Branco - Open Box",
                    ValorCusto = 1000.00m,
                    ValorVenda = 1359.32m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 12,
                    CategoriaId = 6,
                    Nome = "Monitor FreeSync Pro",
                    Descricao = "Monitor curvo de 34 com tecnologia QD-OLED e AMD FreeSync™ Premium Pro",
                    ValorCusto = 6000.00m,
                    ValorVenda = 6289.15m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //suporte para monitores
                new() {
                    Id = 13,
                    CategoriaId = 11,
                    Nome = "Suporte de monitor Armstrong",
                    Descricao = "Suporte de Monitor Armstrong DUO Branco - Elements",
                    ValorCusto = 590.95m,
                    ValorVenda = 849.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 14,
                    CategoriaId = 11,
                    Nome = "Suporte de monitor Armstrong",
                    Descricao = "Suporte de Monitor Armstrong DUO Branco - Elements",
                    ValorCusto = 590.95m,
                    ValorVenda = 849.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 15,
                    CategoriaId = 11,
                    Nome = "Suporte Articulado Zinnia Nimbo",
                    Descricao = "Suporte Articulado Com Pistao a Gas Para Monitor Zinnia Nimbo 100, 17 Pol. a 27 Pol., Branco, ZNO-ZNNBO100-WH01",
                    ValorCusto = 100.99m,
                    ValorVenda = 129.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 16,
                    CategoriaId = 11,
                    Nome = "Suporte Articulado 17-32 VESA",
                    Descricao = "Suporte Para Monitor De Parede A Gás 17 A 32 Articulado Vesa Cor Preto",
                    ValorCusto = 250.85m,
                    ValorVenda = 279.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //suporte notebooks
                new() {
                    Id = 17,
                    CategoriaId = 12,
                    Nome = "Suporte Ergonômico Dobrável Luuk Young S50",
                    Descricao = "Suporte Dobrável Ergonômico Portátil Slim Para Notebook Tablet Ajustável Luuk Young S50 Prateado",
                    ValorCusto = 20.00m,
                    ValorVenda = 24.11m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 18,
                    CategoriaId = 12,
                    Nome = "Suporte Regulável para Notebook",
                    Descricao = "Suporte Mesa Base Notebook Alumínio Regulável Leitura Cor Preto",
                    ValorCusto = 65.85m,
                    ValorVenda = 79.53m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 19,
                    CategoriaId = 12,
                    Nome = "Suporte para Notebook Regulavel com Base Giratoria",
                    Descricao = "Suporte Regulável de Alumínio para Notebook com Base Giratória 360º",
                    ValorCusto = 95.75m,
                    ValorVenda = 115.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 20,
                    CategoriaId = 12,
                    Nome = "Suporte Ergonômica Home Goods",
                    Descricao = "Base Suporte Ergonômico Para Notebook Tablet Dobrável top - Home Good",
                    ValorCusto =  42.75m,
                    ValorVenda = 50.15m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //led para monitores
                new() {
                    Id = 21,
                    CategoriaId = 4,
                    Nome = "Barra de LED Pcyes",
                    Descricao = "Barra de LED para Monitor Pcyes PLMLCB01, 447x85mm, Regulagem Touch, USB, Preto - 111552",
                    ValorCusto =  125.45m,
                    ValorVenda = 169.90m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 22,
                    CategoriaId = 4,
                    Nome = "Led para monitor, com três e 15 modos de cor",
                    Descricao = "Light Bar, Preto, RGB Lightbar, Light Bar Monitor com Tres temperaturas de cor 15 cores modo, Luz Monitor, Led Monitor Light Bar, Barra de Luz para Monitor, Lightbar Monitor, Luminaria Monitor",
                    ValorCusto =  175.99m,
                    ValorVenda = 189.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 23,
                    CategoriaId = 4,
                    Nome = "Led para Monitor E Notebooks Regulável",
                    Descricao = "Bases Luminária Led Monitor E Notebooks Regulável Cor Preta",
                    ValorCusto =  259.65m,
                    ValorVenda = 289.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 24,
                    CategoriaId = 4,
                    Nome = "Led Curvo para Monitor com 3 temperaturas e 7 cores",
                    Descricao = "Gugxiom Barra de luz curvada para monitor, lâmpada de monitor de computador, barra de LED para monitor de PC com 3 ajustes de temperatura de cor e 7 cores RGB, luz de monitor óptico assimétrica de 5V",
                    ValorCusto =  259.69m,
                    ValorVenda = 278.10m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //webcam
                new() {
                    Id = 25,
                    CategoriaId = 16,
                    Nome = "Webcam Aicoco 2K",
                    Descricao = "Web cam aicoco 2k Web Cam Com Microfone Ai Auto Ac610",
                    ValorCusto =  489.99m,
                    ValorVenda = 584.10m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 26,
                    CategoriaId = 16,
                    Nome = "Webcam Philips com microfone",
                    Descricao = "Webcam Philips SPL6208 1080P com microfone para streaming de PC",
                    ValorCusto =  398.33m,
                    ValorVenda = 438.33m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 27,
                    CategoriaId = 16,
                    Nome = "Webcam USB-C Full HD Branca",
                    Descricao = "Logitech StreamCam Webcam USB-C Full HD Blanca",
                    ValorCusto =  598.99m,
                    ValorVenda = 658.96m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 28,
                    CategoriaId = 16,
                    Nome = "Webcam 1080p Full HD com microfone - HUOGUO",
                    Descricao = "1080p Full Hd Usb Webcam Para PC Desktop Laptop Web Camera Com Microfone Fhd - HUOGUO",
                    ValorCusto =  320.95m,
                    ValorVenda = 375.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //teclado
                new() {
                    Id = 29,
                    CategoriaId = 14,
                    Nome = "TECLADO EPOMAKER RT100",
                    Descricao = "TECLADO EPOMAKER RT100",
                    ValorCusto =  495.89m,
                    ValorVenda = 554.22m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 30,
                    CategoriaId = 14,
                    Nome = "Teclado mecânico Attack Shark Ajazz AK820",
                    Descricao = "Attack Shark Ajazz AK820 Teclado mecânico para jogos com botão 75% teclado Hot Swappable Tipo-C com fio junta com 5 camadas de espuma absorvente de ruído branco LED retroiluminado NKRO interruptor",
                    ValorCusto =  299.90m,
                    ValorVenda = 349.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 31,
                    CategoriaId = 14,
                    Nome = "Teclado Gamer Semi - Mecânico",
                    Descricao = "Teclado Gamer Semi - Mecânico Rise Mode G1 Rgb Ptbr (Branco)",
                    ValorCusto =  49.90m,
                    ValorVenda = 69.90m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 32,
                    CategoriaId = 14,
                    Nome = "TECLADO EPOMAKER RT100",
                    Descricao = "TECLADO EPOMAKER RT100",
                    ValorCusto =  579.99m,
                    ValorVenda = 629.22m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                //mouses
                new() {
                    Id = 33,
                    CategoriaId = 7,
                    Nome = "Mouse Logitech G PRO X SUPERLIGHT 2",
                    Descricao = "Mouse Gamer Sem Fio Logitech G PRO X SUPERLIGHT 2 com LIGHTSPEED e Bateria Recarregável",
                    ValorCusto =  800.75m,
                    ValorVenda = 847.71m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 34,
                    CategoriaId = 7,
                    Nome = "Mouse Gamer X6 Attack Shark",
                    Descricao = "Mouse Gamer X6 Attack Shark Tri Mode 26000dpi Paw3395 + Dock Cor Preto",
                    ValorCusto =  199.90m,
                    ValorVenda = 240.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 35,
                    CategoriaId = 7,
                    Nome = "Mouse Gamer X11 Attack Shark",
                    Descricao = "Mouse Gamer X11 Attack Shark Tri Mode 22000dpi Paw3311 Dock Cor Branco",
                    ValorCusto =  189.99m,
                    ValorVenda = 250.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 36,
                    CategoriaId = 7,
                    Nome = "Mouse Logitech G PRO Wireless LIGHTSPEED",
                    Descricao = "Mouse Gamer Sem Fio Logitech G PRO Wireless LIGHTSPEED RGB",
                    ValorCusto =  500.99m,
                    ValorVenda = 550.00m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                //fones
                new() {
                    Id = 37,
                    CategoriaId = 3,
                    Nome = "Headset Redragon Zeus Pro",
                    Descricao = "Headtset Gamer Redragon Zeus Pro, Surround 7.1, Cabo USB-C Removível, Wireless, c/Microfone, Preto - H510-PRO",
                    ValorCusto =  415.00m,
                    ValorVenda = 430.00m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 38,
                    CategoriaId = 3,
                    Nome = "Fone gamer HAVIT FUXI-H3",
                    Descricao = "HAVIT Fone de Ouvido Headset Gamer FUXI-H3 Quad-Mode (com fio e sem fio, Wireless 2,4GHz, Bluetooth, Cabo USB-C, Cabo Auxiliar 3.5mm). Surround, Baixa Latência - Preto",
                    ValorCusto =  199.99m,
                    ValorVenda = 250.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 39,
                    CategoriaId = 3,
                    Nome = "Headset 2.4GHz para Pc",
                    Descricao = "2.4ghz Gaming Headset Para Pc,ps4,ps5,mac,nintendo Switch",
                    ValorCusto =  300.00m,
                    ValorVenda = 338.90m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 40,
                    CategoriaId = 3,
                    Nome = "Headset gamer sem fio JBL Quantum 350",
                    Descricao = "Headset Gamer Sem Fio Quantum 350 Para Pc Drivers 40mm Jbl Cor Preto",
                    ValorCusto =  329.99m,
                    ValorVenda = 379.99m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                //caixa de som
                new() {
                    Id = 41,
                    CategoriaId = 10,
                    Nome = "Caixa de Som EDIFIER G2000",
                    Descricao = "Caixa de som Gamer G2000 Bluetooth 16W RMS EDIFIER - Branco",
                    ValorCusto =  415.55m,
                    ValorVenda = 449.19m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 42,
                    CategoriaId = 10,
                    Nome = "Caixa de Som 2.1 Speaker",
                    Descricao = "HP Caixa de som 2.1 DHS-2111S Preta Speaker com Alimentacao USB e conector 3.5mm potência do Subwoofer 5W 2B285AA",
                    ValorCusto =  129.90m,
                    ValorVenda = 169.90m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 43,
                    CategoriaId = 10,
                    Nome = "Caixa de Som BESTISAN SR0",
                    Descricao = "BESTISAN Bluetooth Bookshelf RCA Speakers for Record Player, Turntable Speaker with 4 inch Woofer, Optical/RCA Inputs for PC and TV, White, Pair, SR06",
                    ValorCusto =  345.95m,
                    ValorVenda =  377.94m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 44,
                    CategoriaId = 10,
                    Nome = "Caixa de Som BESTISAN SR04",
                    Descricao = "Bestisan SR04 Bluetooth Bookshelf Speakers for Record Player, Powered Studio Speaker for TV with Sub Out Port, Horn Tweeter and Optical/RCA/BT Inputs",
                    ValorCusto = 390.49m,
                    ValorVenda = 427.62m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //suporte de pulso
                new() {
                    Id = 45,
                    CategoriaId = 13,
                    Nome = "Suporte de Pulso Nuvem",
                    Descricao = "Suporte de pulso ergonômico para teclado em formato de nuvem",
                    ValorCusto = 295.89m,
                    ValorVenda = 320.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 46,
                    CategoriaId = 13,
                    Nome = "Suporte de pulso Multilaser Ac033",
                    Descricao = "Bestisan SR04 Bluetooth Bookshelf Speakers for Record Player, Powered Studio Speaker for TV with Sub Out Port, Horn Tweeter and Optical/RCA/BT Inputs",
                    ValorCusto = 25.90m,
                    ValorVenda = 37.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 47,
                    CategoriaId = 13,
                    Nome = "Suporte de Pulso e Mouse Pad",
                    Descricao = "Bloss Almofada de mesa de couro e descanso de pulso para teclado, mouse pad grande + teclado + suporte de pulso para mouse, protetor de mesa antiderrapante para escritório, casa (80 x 40 cm, bege)",
                    ValorCusto = 195.85m,
                    ValorVenda = 214.75m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 48,
                    CategoriaId = 13,
                    Nome = "Suporte de pulso ergonômico",
                    Descricao = "Suporte de descanso de pulso para teclado e mouse, com espuma de memória ergonômica, base antiderrapante para escritório doméstico, laptop, desktop",
                    ValorCusto = 15.90m,
                    ValorVenda = 25.95m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //assistentes
                new() {
                    Id = 49,
                    CategoriaId = 1,
                    Nome = "Eilik Robô",
                    Descricao = "Eilik Robô - Robô Inteligente",
                    ValorCusto = 1250.00m,
                    ValorVenda = 1539.10m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 50,
                    CategoriaId = 1,
                    Nome = "Alexa Echo Dot 5ª geração",
                    Descricao = "Echo Dot 5ª geração Amazon, com Alexa, Smart Speaker, Preto - B09B8VGCR8",
                    ValorCusto = 420.99m,
                    ValorVenda = 489.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 51,
                    CategoriaId = 1,
                    Nome = "Alexa Echo Pop Amazon",
                    Descricao = "Echo Pop Amazon, com Alexa, Smart Speaker, Som Envolvente, Branco - B09ZXN77L2",
                    ValorCusto = 415.89m,
                    ValorVenda = 499.99m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 52,
                    CategoriaId = 1,
                    Nome = "Alexa Echo Dot 3ª Geração",
                    Descricao = "Alexa Echo Dot Geração Alexa Smart Speaker Wi-Fi - Amazon",
                    ValorCusto = 1250.00m,
                    ValorVenda = 1345.94m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //relogios
                new() {
                    Id = 53,
                    CategoriaId = 9,
                    Nome = "Relógio Digital 3D LED",
                    Descricao = "Relógio Digital 3D LED De Parede e Mesa Design Moderno Luz Noturna Decoração",
                    ValorCusto = 25.00m,
                    ValorVenda = 40.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 54,
                    CategoriaId = 9,
                    Nome = "Relógio LED Digital",
                    Descricao = "Relógio despertador digital, Relógio LED para quarto, Relógio eletrônico de mesa com visor de temperatura, brilho ajustável, controle de voz, visor 12/24H para casa, dormitório, escritório",
                    ValorCusto = 45.99m,
                    ValorVenda = 52.90m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //umidificadores
                new() {
                    Id = 55,
                    CategoriaId = 15,
                    Nome = "Umidificador Nuvem",
                    Descricao = "Umidificador em forma de nuvem com suporte dourado",
                    ValorCusto = 189.99m,
                    ValorVenda = 285.00m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 56,
                    CategoriaId = 15,
                    Nome = "Umidificador Led 500ml",
                    Descricao = "Umidificador Ar Aromatizador Purificador Portátil Led 500ml",
                    ValorCusto = 65.90m,
                    ValorVenda = 78.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                //cadeiras
                new() {
                    Id = 57,
                    CategoriaId = 2,
                    Nome = "Cadeira Gamer Flexform Delta",
                    Descricao = "Cadeira Gamer Flexform Delta White N Blue",
                    ValorCusto = 1299.99m,
                    ValorVenda = 1457.19m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
                new() {
                    Id = 58,
                    CategoriaId = 2,
                    Nome = "Cadeira Gamer Flexform Alpha Pro",
                    Descricao = "Cadeira Gamer Flexform Alpha 2 Pro Black",
                    ValorCusto = 2999.99m,
                    ValorVenda = 3509.10m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 59,
                    CategoriaId = 2,
                    Nome = "Cadeira Gamer Branca com Rosa Claro",
                    Descricao = "Cadeira Gamer Home Office Branca com Rosa Claro",
                    ValorCusto = 2899.99m,
                    ValorVenda = 3509.10m,
                    QtdeEstoque = 20,
                    Destaque = true
                },
                new() {
                    Id = 60,
                    CategoriaId = 2,
                    Nome = "Cadeira Gamer XT Racer Viking Series",
                    Descricao = "Cadeira Gamer XT Racer Viking Series, Até 120 Kg, Com Almofadas, Reclinável, Descanso de Braço 3D, Preto - XTR-014o",
                    ValorCusto = 599.90m,
                    ValorVenda = 899.99m,
                    QtdeEstoque = 20,
                    Destaque = false
                },
            };
            builder.Entity<Produto>().HasData(produtos);

            List<ProdutoFoto> fotos = new() {
                new() { Id = 1, ProdutoId = 1, Foto = "/img/produtos/1/mesa-gamer-1.jpg"},
            };
        }        
    }