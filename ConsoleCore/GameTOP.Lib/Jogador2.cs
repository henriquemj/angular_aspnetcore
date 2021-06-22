using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Pele esta chutando \n";
        }

        public string Corre()
        {
            return "Pele esta correndo \n";
        }

        public string Passe()
        {
            return "Pele esta passando \n";
        }
    }
}