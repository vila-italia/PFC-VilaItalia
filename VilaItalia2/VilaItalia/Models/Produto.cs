using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VilaItalia.Models
{
    public enum Tipo { Bebida, Sobremesa }
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoMedio { get; set; }
        public double PercentLucro { get; set; }
        public double PrecoSugerido { get; set; }
        public double Aliquota { get; set; }
        public Tipo Tipo { get; set; }
        public Medida Medida { get; set; }
    }
}