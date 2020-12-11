namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class MegaMan : Player
    {
        private string buster = "Buster";
        public string Buster{
            get{return buster;}
        }

        public override string Correr(){
            return "Correndo em velocidade 2x";
        }
    }
}