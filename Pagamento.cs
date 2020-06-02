using System;

namespace Aula8Abstracao
{
    public class Pagamento
    {
        public DateTime data { get; set; }

        public float valor { get; set; }
        public string Pagar(float valorPago){
            return "Valor Pago: R$"+valorPago;
        }
        public string Cancelar(){
            return "Pagamento Cancelado com Sucesso";
        }
        
    }
}