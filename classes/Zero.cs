namespace AulaPOO_PolimosrfismoSobreposicao.classes
{
    public class Zero : Player
    {
        private string sword = "Sword";
        public string Sword{
            get{return sword;}
        }

        public override string Pular(){
            return "Pulando 1 Metro + um dash(impulso) para frente após um pulo";
        }
    }
}