namespace Atividade
{
    class Client
    {
        public string nome {get; set;}
        public string endereco {get; set;}  
        public float valor {get; protected set;} 
        public float valorimpost {get; protected set;} 
        public float total {get; protected set;}

        public virtual void Pagarimpost (float x) 
        {
        this.valor = x;
        this.valorimpost = this.valor * 10/100;
        this.total = this.valor + valorimpost; 
       } 
    }
}
