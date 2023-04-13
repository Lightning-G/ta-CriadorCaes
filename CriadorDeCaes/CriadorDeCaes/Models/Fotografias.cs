using System.ComponentModel.DataAnnotations.Schema;

namespace CriadorDeCaes.Models
{
    public class Fotografias
    {
        public int ID {get; set;} 

        public string NomeFicheiro { get; set;} 

        public string Local { get; set;}

        public DateTime DataFotografia { get; set;}


        [ForeignKey(nameof(Cao))]

        public int AnimalFK { get; set;}

        public Caes Cao { get; set;}

    } 
}
