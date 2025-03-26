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
                    Id = 7,
                    CategoriaId = 8,
                    Nome = "Mouse Pad Corsair",
                    Descricao = "Mouse Pad Corsair MM700 3XL RGB",
                    ValorCusto = 650.00m,
                    ValorVenda = 759.20m,
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