using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorDeCaes.Models
{
    public class Caes
    {

        public int ID { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set;}

        public DateTime datanasc { get; set;}

        public DateTime datacompra { get; set;}

        public string nregLOP { get; set;}

        /*Criaçao das chaves forasteiras*/


        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set;}   
        public Criadores Criador { get; set;} 




    }
}
