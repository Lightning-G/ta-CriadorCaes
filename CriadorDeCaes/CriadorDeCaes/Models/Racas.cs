using System.Security.Principal;

namespace CriadorDeCaes.Models
{
    public class Racas
    {

        public Racas() {
            ListaCaes = new HashSet<Caes>();
            ListaCriadores = new HashSet<Caes>();
        }


        public int ID { get; set; } 

        public string Nome { get; set; }  
        
        public ICollection<Caes> ListaCaes { get; set;}

        public ICollection<Criadores> ListaCriadores { get; set; }
    }
}
