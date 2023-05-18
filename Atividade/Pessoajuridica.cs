namespace Atividade
{
    class Pessoajuridica : Client
    {
        public string nomej {get; set;}
        public string endj {get; set;}
        public string cnpj {get; set;}
        public string ie {get; set;}
         
        public override void Pagarimpost (float x) 
        {
        this.valor = x;
        this.valorimpost = this.valor * 20/100;
        this.total = this.valor + valorimpost;
        } 
    }
}