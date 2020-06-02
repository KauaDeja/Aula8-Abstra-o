namespace Aula8Abstracao
{
    public class Cartao : Pagamento
    {
       protected string token = "jengjuneujignrjungrji";
       public string bandeira { get; set; }
       public string titular  { get; set; }
       public int numeroy { get; set; }
       public string cvv{ get; set; }

       protected bool ValidarToken(){
           if(token != null){
               return true;
           }
           return false;
       }
    
    }
}