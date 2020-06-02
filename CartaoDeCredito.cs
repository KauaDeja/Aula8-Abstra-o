namespace Aula8Abstracao
{
    public class CartaoDeCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite(float acrescimo){
            token = "ifemufenyhrengjhhrhj";
            limite = limite + acrescimo;
        }
    }
}