using System;

namespace Aula23Listas
{
    public class Cartao
    {
        public string titular{ get; set; }
        public int numero { get; set; }
        public string bandeira { get; set; }
        public DateTime vencimento { get; set; }
        public int cvv{ get; set; }

        public Cartao(string _titular, int _numero, string _bandeira){
            this.titular = _titular;
            this.numero = _numero;
            this.bandeira = _bandeira;
        }

    }
}