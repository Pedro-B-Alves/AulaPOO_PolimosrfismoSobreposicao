namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class Player
    {
        private float velocidade = 1;
        private float forcaPulo = 1;
        
        public virtual string Correr(){
            return "Correndo em velocidade "+velocidade+"x";
        }
        public virtual string Pular(){
            return "Pulando "+forcaPulo+" Metro";
        }
    }
}