namespace CriadorDeCaes.Models
{
    public class Criadores

    {

        public Criadores()
        {
            ListaCaes = new HashSet<Caes>();
            ListaRacas = new HashSet<Racas>();  
        }

        public int ID { get; set; }    

        public string Nome { get; set; }    

        public string NomeComercial { get; set; }

        public string Morada { get; set; }

        public string CodPost { get; set; }

        public string Pais { get; set; }

        public string Email { get; set; }

        public string telefone { get; set; }


        public ICollection<Caes> ListaCaes { get; set; }

        public ICollection<Racas> ListaRacas { get; set; }
    }
}
