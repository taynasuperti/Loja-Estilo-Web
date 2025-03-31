using LojaEstiloWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LojaEstiloWeb.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        List<Categoria> categorias = new() {
                new() {Id = 1, Nome = "Assistentes", Foto = "/img/categorias/assistente/eilik-1.jpg"},
                new() {Id = 2, Nome = "Cadeiras", Foto = "/img/categorias/cadeira/cadeira-2.jpg"},
                new() {Id = 3, Nome = "Fones", Foto = "/img/categorias/fone/fone-2.webp"},
                new() {Id = 4, Nome = "Leds", Foto = "/img/categorias/led/led-monitor-2.jpg"},
                new() {Id = 5, Nome = "Mesas", Foto = "/img/categorias/mesa/mesa-gamer-1.jpg"},
                new() {Id = 6, Nome = "Monitores", Foto = "/img/categorias/monitor/monitor-1.webp"},
                new() {Id = 7, Nome = "Mouses", Foto = "/img/categorias/mouse/mouse-5.jpg"},
                new() {Id = 8, Nome = "Mouse pad", Foto = "/img/categorias/mouse-pad/mousepad-3.jpg"},
                new() {Id = 9, Nome = "Relógios", Foto = "/img/categorias/relogio/relogio-2.jpeg"},
                new() {Id = 10, Nome = "Caixas de Som", Foto = "/img/categorias/som/caixa-de-som-2.jpeg"},
                new() {Id = 11, Nome = "Suportes para Monitor", Foto = "/img/categorias/suporte/suporte-monitor-3.jpg"},
                new() {Id = 12, Nome = "Suportes para Notbook", Foto = "/img/categorias/suporte-notbook/suporte-2.jpeg"},
                new() {Id = 13, Nome = "Suportes de pulso", Foto = "/img/categorias/suporte-pulso/apoio-de-pulso.jpg"},
                new() {Id = 14, Nome = "Teclados", Foto = "/img/categorias/teclado/teclado-customizavel-1.jpg"},
                new() {Id = 15, Nome = "Umidificador", Foto = "/img/categorias/umidificador/difusor-2.webp"},
                new() {Id = 16, Nome = "Webcam", Foto = "/img/categorias/webcam/web-cam-1.jpg"},
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
            //mesas
            new() { Id = 1, ProdutoId = 1, Foto = "/img/produtos/1/mesa-gamer-1.jpg"},
            new() { Id = 2, ProdutoId = 1, Foto = "/img/produtos/1/mesa-gamer-2.jpeg"},
            new() { Id = 3, ProdutoId = 2, Foto = "/img/produtos/2/mesa-1.webp"},
            new() { Id = 4, ProdutoId = 2, Foto = "/img/produtos/2/mesa-2.jpeg"},
            new() { Id = 5, ProdutoId = 2, Foto = "/img/produtos/2/mesa-1.jpeg"},
            new() { Id = 6, ProdutoId = 3, Foto = "/img/produtos/3/mesa-1.jpeg"},
            new() { Id = 7, ProdutoId = 3, Foto = "/img/produtos/3/mesa-2.jpeg"},
            new() { Id = 8, ProdutoId = 4, Foto = "/img/produtos/4/mesa-4.jpeg"},
            new() { Id = 9, ProdutoId = 4, Foto = "/img/produtos/4/mesa-2.jpeg"},
            //mousepads
            new() { Id = 10, ProdutoId = 5, Foto = "/img/produtos/5/mousepaad-1-1.jpeg"},
            new() { Id = 11, ProdutoId = 5, Foto = "/img/produtos/5/mousepad-1.webp"},
            new() { Id = 12, ProdutoId = 5, Foto = "/img/produtos/5/mousepaad-2.jpeg"},
            new() { Id = 13, ProdutoId = 6, Foto = "/img/produtos/6/mousepad-2-1.webp"},
            new() { Id = 14, ProdutoId = 6, Foto = "/img/produtos/6/mousepad-2-2.jpg"},
            new() { Id = 15, ProdutoId = 6, Foto = "/img/produtos/6/mousepad-3.jpg"},
            new() { Id = 16, ProdutoId = 6, Foto = "/img/produtos/6/mousepad-2-2.jpg"},
            new() { Id = 17, ProdutoId = 7, Foto = "/img/produtos/7/mousepad-3-1.jpg"},
            new() { Id = 18, ProdutoId = 7, Foto = "/img/produtos/7/mousepad-4-1.jpeg"},
            new() { Id = 19, ProdutoId = 7, Foto = "/img/produtos/7/mousepad-4-2.jpeg"},
            new() { Id = 20, ProdutoId = 7, Foto = "/img/produtos/7/mousepad-4-3.jpeg"},
            new() { Id = 21, ProdutoId = 8, Foto = "/img/produtos/8/mousepad-4-1.webp"},
            new() { Id = 22, ProdutoId = 8, Foto = "/img/produtos/8/mousepad-4-2.webp"},
            //monitores
            new() { Id = 23, ProdutoId = 9, Foto = "/img/produtos/9/monitor-1.webp"},
            new() { Id = 24, ProdutoId = 9, Foto = "/img/produtos/9/monitor-3.webp"},
            new() { Id = 25, ProdutoId = 9, Foto = "/img/produtos/9/monitor-2.webp"},
            new() { Id = 26, ProdutoId = 10, Foto = "/img/produtos/10/monitor-17-2.jpg"},
            new() { Id = 27, ProdutoId = 10, Foto = "/img/produtos/10/monitor-17-3.jpeg"},
            new() { Id = 28, ProdutoId = 11, Foto = "/img/produtos/11/monitor-17-3.jpg"},
            new() { Id = 29, ProdutoId = 11, Foto = "/img/produtos/11/monitor-17-4.jpeg"},
            new() { Id = 30, ProdutoId = 12, Foto = "/img/produtos/12/monitor-17-4.jpeg"},
            new() { Id = 31, ProdutoId = 12, Foto = "/img/produtos/12/monitor-17-5.jpeg"},
            new() { Id = 32, ProdutoId = 12, Foto = "/img/produtos/12/monitor-17-6.jpeg"},
            //suporte para monitor
            new() { Id = 33, ProdutoId = 13, Foto = "/img/produtos/13/suporte-monitor-1.jpg"},
            new() { Id = 34, ProdutoId = 13, Foto = "/img/produtos/13/suporte-monitor-2.webp"},
            new() { Id = 35, ProdutoId = 14, Foto = "/img/produtos/14/suporte-monitor-10-2-2.jpeg"},
            new() { Id = 36, ProdutoId = 14, Foto = "/img/produtos/14/suporte-monitor-10-2.jpeg"},
            new() { Id = 37, ProdutoId = 15, Foto = "/img/produtos/15/suporte-monitor-10-3-2.jpeg"},
            new() { Id = 38, ProdutoId = 15, Foto = "/img/produtos/15/suporte-monitor-10-3.jpeg"},
            new() { Id = 39, ProdutoId = 16, Foto = "/img/produtos/16/suporte-monitor-17-4-2.jpeg"},
            new() { Id = 40, ProdutoId = 16, Foto = "/img/produtos/16/suporte-monitor-17-4.jpeg"},
            //suporte para notebook
            new() { Id = 41, ProdutoId = 17, Foto = "/img/produtos/17/suporte-1.jpg"},
            new() { Id = 42, ProdutoId = 17, Foto = "/img/produtos/17/suporte-2.jpeg"},
            new() { Id = 43, ProdutoId = 18, Foto = "/img/produtos/18/suporte-3-2.jpeg"},
            new() { Id = 44, ProdutoId = 18, Foto = "/img/produtos/18/suporte-3-3.jpeg"},
            new() { Id = 45, ProdutoId = 19, Foto = "/img/produtos/19/suporte-3-3.jpeg"},
            new() { Id = 46, ProdutoId = 19, Foto = "/img/produtos/19/suporte-3-4.jpeg"},
            new() { Id = 47, ProdutoId = 20, Foto = "/img/produtos/20/suporte-3-4.jpeg"},
            new() { Id = 48, ProdutoId = 20, Foto = "/img/produtos/20/suporte-3-5.jpeg"},
            //leds
            new() { Id = 49, ProdutoId = 21, Foto = "/img/produtos/21/led-monitor-2.jpg"},
            new() { Id = 50, ProdutoId = 21, Foto = "/img/produtos/21/led-monitor-3.jpeg"},
            new() { Id = 51, ProdutoId = 21, Foto = "/img/produtos/21/led-monitor-4.jpg"},
            new() { Id = 52, ProdutoId = 21, Foto = "/img/produtos/21/led-monitor.jpg"},
            new() { Id = 53, ProdutoId = 22, Foto = "/img/produtos/22/led-monitor-11-2-1.jpeg"},
            new() { Id = 54, ProdutoId = 22, Foto = "/img/produtos/22/led-monitor-11-2.jpeg"},
            new() { Id = 55, ProdutoId = 23, Foto = "/img/produtos/23/led-monitor-11-3-2.jpeg"},
            new() { Id = 56, ProdutoId = 23, Foto = "/img/produtos/23/led-monitor-11-3-4.jpeg"},
            new() { Id = 57, ProdutoId = 23, Foto = "/img/produtos/23/led-monitor-11-3.jpeg"},
            new() { Id = 58, ProdutoId = 24, Foto = "/img/produtos/24/led-monitor-11-4-2.jpeg"},
            new() { Id = 59, ProdutoId = 24, Foto = "/img/produtos/24/led-monitor-11-3.jpeg"},
            //webcam
            new() { Id = 60, ProdutoId = 25, Foto = "/img/produtos/25/web-cam-1.jpg"},
            new() { Id = 61, ProdutoId = 25, Foto = "/img/produtos/25/web-cam-1.webp"},
            new() { Id = 62, ProdutoId = 26, Foto = "/img/produtos/26/webcam8-2-1.jpeg"},
            new() { Id = 63, ProdutoId = 26, Foto = "/img/produtos/26/webcam-8-2.jpeg"},
            new() { Id = 64, ProdutoId = 27, Foto = "/img/produtos/27/webcam-8-3-1.jpeg"},
            new() { Id = 65, ProdutoId = 27, Foto = "/img/produtos/27/webcam-8-3.jpeg"},
            new() { Id = 66, ProdutoId = 28, Foto = "/img/produtos/28/webcam-8-4-1.jpeg"},
            new() { Id = 67, ProdutoId = 28, Foto = "/img/produtos/28/webcam-8-4.jpeg"},
            //teclado
            new() { Id = 68, ProdutoId = 29, Foto = "/img/produtos/29/teclado-customizavel-2.jpg"},
            new() { Id = 69, ProdutoId = 29, Foto = "/img/produtos/29/teclado-mecanico-3.jpg"},
            new() { Id = 70, ProdutoId = 30, Foto = "/img/produtos/30/teclado-1-2-3.jpeg"},
            new() { Id = 71, ProdutoId = 30, Foto = "/img/produtos/30/teclado-1-2-1.jpeg"},
            new() { Id = 72, ProdutoId = 30, Foto = "/img/produtos/30/teclado-1-2.jpeg"},
            new() { Id = 73, ProdutoId = 31, Foto = "/img/produtos/31/teclado-1-3-2.jpeg"},
            new() { Id = 74, ProdutoId = 31, Foto = "/img/produtos/31/teclado-1-3.jpeg"},
            new() { Id = 75, ProdutoId = 32, Foto = "/img/produtos/32/teclado-1-4.webp"},
            new() { Id = 76, ProdutoId = 32, Foto = "/img/produtos/32/teclado-customizavel-1.jpg"},
            //mouses
            new() { Id = 77, ProdutoId = 33, Foto = "/img/produtos/33/mouse-1-6.webp"},
            new() { Id = 78, ProdutoId = 33, Foto = "/img/produtos/33/mouse-2.jpg"},
            new() { Id = 79, ProdutoId = 33, Foto = "/img/produtos/33/mouse-3.jpg"},
            new() { Id = 80, ProdutoId = 34, Foto = "/img/produtos/34/mouse-2-2-2.jpeg"},
            new() { Id = 81, ProdutoId = 34, Foto = "/img/produtos/34/mouse-2-2.jpeg"},
            new() { Id = 82, ProdutoId = 35, Foto = "/img/produtos/35/mouse-2-3-1.jpeg"},
            new() { Id = 83, ProdutoId = 35, Foto = "/img/produtos/35/mouse-2-3.jpeg"},
            new() { Id = 84, ProdutoId = 36, Foto = "/img/produtos/36/mouse-2-4-3.jpeg"},
            new() { Id = 85, ProdutoId = 36, Foto = "/img/produtos/36/mouse-2-4-2.jpeg"},
            //fones
            new() { Id = 86, ProdutoId = 37, Foto = "/img/produtos/37/fone-1.jpg"},
            new() { Id = 87, ProdutoId = 37, Foto = "/img/produtos/37/fone-2.webp"},
            new() { Id = 88, ProdutoId = 38, Foto = "/img/produtos/38/fone-7-2-2.jpeg"},
            new() { Id = 89, ProdutoId = 38, Foto = "/img/produtos/38/fone-7-2-3.jpeg"},
            new() { Id = 90, ProdutoId = 38, Foto = "/img/produtos/38/fone-7-2.jpeg"},
            new() { Id = 91, ProdutoId = 39, Foto = "/img/produtos/39/fone-7-3-2.jpeg"},
            new() { Id = 92, ProdutoId = 39, Foto = "/img/produtos/39/fone-7-3.jpeg"},
            new() { Id = 93, ProdutoId = 40, Foto = "/img/produtos/40/fone-7-4-2.jpeg"},
            new() { Id = 94, ProdutoId = 40, Foto = "/img/produtos/40/fone-7-4.jpeg"},
            //caixas de som
            new() { Id = 95, ProdutoId = 41, Foto = "/img/produtos/41/caixa-de-som-1.jpg"},
            new() { Id = 96, ProdutoId = 41, Foto = "/img/produtos/41/caixa-de-som-2.jpeg"},
            new() { Id = 97, ProdutoId = 42, Foto = "/img/produtos/42/caixa-de-som-16-2-2.jpeg"},
            new() { Id = 98, ProdutoId = 42, Foto = "/img/produtos/42/caixa-de-som-16-2.jpeg"},
            new() { Id = 99, ProdutoId = 43, Foto = "/img/produtos/43/som-16-3.jpeg"},
            new() { Id = 100, ProdutoId = 43, Foto = "/img/produtos/43/-som-16-3-2.jpeg"},
            new() { Id = 101, ProdutoId = 44, Foto = "/img/produtos/44/som-16-4-2.jpeg"},
            new() { Id = 102, ProdutoId = 44, Foto = "/img/produtos/44/som-16-4.jpeg"},
            //suporte de pulso
            new() { Id = 103, ProdutoId = 45, Foto = "/img/produtos/45/apoio-de-pulso-2.jpg"},
            new() { Id = 104, ProdutoId = 45, Foto = "/img/produtos/45/apoio-de-pulso.jpg"},
            new() { Id = 105, ProdutoId = 46, Foto = "/img/produtos/46/apoio-de-pulso-9-2-2.jpeg"},
            new() { Id = 106, ProdutoId = 46, Foto = "/img/produtos/46/apoio-de-pulso-9-2.jpeg"},
            new() { Id = 107, ProdutoId = 47, Foto = "/img/produtos/47/suporte-de-pulso-9-3-2.jpeg"},
            new() { Id = 108, ProdutoId = 47, Foto = "/img/produtos/47/suporte-de-pulso-9-3.jpeg"},
            new() { Id = 109, ProdutoId = 48, Foto = "/img/produtos/48/suporte-de-pulso-9-4-2.jpeg"},
            new() { Id = 110, ProdutoId = 48, Foto = "/img/produtos/48/suporte-de-pulso-9-4.jpeg"},
            //assistentes
            new() { Id = 111, ProdutoId = 49, Foto = "/img/produtos/49/eilik-1.jpg"},
            new() { Id = 112, ProdutoId = 49, Foto = "/img/produtos/49/eilik-2.jpg"},
            new() { Id = 113, ProdutoId = 50, Foto = "/img/produtos/50/alexa-14-2-2.jpeg"},
            new() { Id = 114, ProdutoId = 50, Foto = "/img/produtos/50/alexa-14-2-3.jpeg"},
            new() { Id = 115, ProdutoId = 50, Foto = "/img/produtos/50/alexa-14-2-4.jpg"},
            new() { Id = 116, ProdutoId = 50, Foto = "/img/produtos/50/alexa-14-2.jpeg"},
            new() { Id = 117, ProdutoId = 51, Foto = "/img/produtos/51/alexa-14-3.png"},
            new() { Id = 118, ProdutoId = 51, Foto = "/img/produtos/51/alexa-14-3.png"},
            new() { Id = 119, ProdutoId = 52, Foto = "/img/produtos/52/alexa-14-4-2.jpeg"},
            new() { Id = 120, ProdutoId = 52, Foto = "/img/produtos/52/alexa-14-4.jpg"},
            //relógios
            new() { Id = 121, ProdutoId = 53, Foto = "/img/produtos/53/relogio-1.jpg"},
            new() { Id = 122, ProdutoId = 53, Foto = "/img/produtos/53/relogio-2.jpeg"},
            new() { Id = 123, ProdutoId = 54, Foto = "/img/produtos/54/relogio-12-2-2.jpeg"},
            new() { Id = 124, ProdutoId = 54, Foto = "/img/produtos/54/relogio-12-2.jpeg"},
            //umidificadores
            new() { Id = 125, ProdutoId = 55, Foto = "/img/produtos/55/difusor-1.jpg"},
            new() { Id = 126, ProdutoId = 55, Foto = "/img/produtos/55/difusor-2.webp"},
            new() { Id = 127, ProdutoId = 55, Foto = "/img/produtos/55/difusor-3.webp"},
            new() { Id = 128, ProdutoId = 56, Foto = "/img/produtos/56/difusor-15-2-2.jpeg"},
            new() { Id = 129, ProdutoId = 56, Foto = "/img/produtos/56/difusor-15-2-3.jpeg"},
            new() { Id = 130, ProdutoId = 56, Foto = "/img/produtos/56/difusor-15-2.jpeg"},
            //cadeiras
            new() { Id = 131, ProdutoId = 57, Foto = "/img/produtos/57/cadeira-1.webp"},
            new() { Id = 132, ProdutoId = 57, Foto = "/img/produtos/57/cadeira-2.jpg"},
            new() { Id = 133, ProdutoId = 58, Foto = "/img/produtos/58/cadeira-4-2.webp"},
            new() { Id = 134, ProdutoId = 59, Foto = "/img/produtos/59/cadeira-4-3.webp"},
            new() { Id = 135, ProdutoId = 59, Foto = "/img/produtos/59/cadeira-4-3-2.jpeg"},
            new() { Id = 136, ProdutoId = 60, Foto = "/img/produtos/60/cadeira-4-2-2.jpeg"},
            new() { Id = 137, ProdutoId = 60, Foto = "/img/produtos/60/cadeira-4-4.jpeg"},

        };
        builder.Entity<ProdutoFoto>().HasData(fotos);
        #region Populate Roles - Perfil de Usuário
        List<IdentityRole> roles = new()
            {
                new IdentityRole(){
                    Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
                    Name ="Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole(){
                    Id ="bec71b05-8f3d-4849-88bb-0e8d518d2de8",
                    Name="Funcionário",
                    NormalizedName="FUNCIONÁRIO"
                },
                new IdentityRole(){
                    Id="ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                    Name="Cliente",
                    NormalizedName="CLIENTE"
                },
            };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuário
        List<Usuario> usuarios = new() {
            new Usuario(){
                Id = "ddf093a6-6cb5-9a64-83da34aee005",
                Email = "taynasuperti@gmail.com",
                NormalizedEmail = "TAYNASUPERTI@GMAIL.COM",
                UserName = "@taynasuperti",
                NormalizedUserName = "TAYNASUPERTI",
                LockoutEnabled = true, 
                EmailConfirmed = true, 
                Nome = "Tayná Carolina Miguel Superti",
                DataNascimento = DateTime.Parse("06/11/2006"),
                Foto = "/img/usuarios/ddf093a6-6cb5-4ff7-9a64-83da34aee005.png"
            }
        };
        foreach (var user in usuarios)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion

    }

}