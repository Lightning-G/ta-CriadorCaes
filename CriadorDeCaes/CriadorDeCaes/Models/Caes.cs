using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorDeCaes.Models
{
    public class Caes
    {

        public Caes() {
            ListaFotografias=new HashSet<Fotografias>();
        }

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



        [ForeignKey(nameof(Raca))]
        public int RacaFK { get; set;}

        public Racas Raca { get; set;}


        public ICollection<Fotografias> ListaFotografias { get; set;}


    }
}
