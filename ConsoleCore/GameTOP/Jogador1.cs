namespace GameTOP
{
public class Jogador1
    {
        public readonly string _Nome;

        public Jogador1(string nome)
        {
            _Nome = nome;
        }

        //Chuta
        public string chuta()
        {
            return $"{_Nome} está chutando \n";
        }
        //Corre
        public string corre()
        {            return $"{_Nome} está correndo \n";
        }
        //Passe
        public string passe()
        {
            return $"{_Nome} está passando \n";
        }
    }
}