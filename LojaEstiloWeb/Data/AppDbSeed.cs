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
                new() {
                    Id = 1,
                    CategoriaId = 1,
                    Nome = "",
                    Descricao = "",
                    ValorCusto = "",
                    ValorVenda = "",
                    QtdeEstoque = ,
                    Destaque = true
                }
            };
            builder.Entity<Produto>().HasData(produtos);

            List<ProdutoFoto> fotos = new() {
                new() { Id = 1, ProdutoId = 1, Foto = "/img/produtos/1/mesa-gamer-1.jpg"},
            };
        }        
    }