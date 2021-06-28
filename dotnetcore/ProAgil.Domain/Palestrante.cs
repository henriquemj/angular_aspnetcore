using System.Collections.Generic;

namespace ProAgil.Domain
{
    public class Palestrante
    {
        public int Id {get; set;}
        public int Nome {get; set;}
        public int MiniCurriculo {get; set;}
        public int ImagemURL {get; set;}
        public int Telefone {get; set;}
        public int Email {get; set;}

        public List<RedeSocial> RedesSociais {get; set;}
        public List<PalestranteEvento>  PalestrantesEventos {get; set;}

    }
}