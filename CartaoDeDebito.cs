namespace Aula8Abstracao
{
    public class CartaoDeDebito : Cartao
    {
        public float saldo { get; set; }

        public string Transferir(float valor){
            return "Transferencia Efetuada";
        }
        public string PagarTitulo(){
            return "Título Pago";
        }
    }
}