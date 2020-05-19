using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterBot.DTO
{
    public class RespostaDTO
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string NomeUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string Texto { get; set; }
        public long NumeroSeguidores { get; set; }
        public DateTime DataPostagem { get; set; }

    }
}
