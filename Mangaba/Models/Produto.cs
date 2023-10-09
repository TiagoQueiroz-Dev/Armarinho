using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armarinho.Models;

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
    }
