namespace mis_librerias
{
    public class Personaje
    {

        string nombre;
        int suerte;
        int vida;
        int hambre;
        string salud;

        public Personaje(string nombre, int suerte)
        {
            this.nombre = nombre;
            this.suerte = suerte;
            this.vida = 100;
            this.hambre = 10;
            this.salud = "Bueno";
        }

        public string Nombre { get => nombre;  }
        public int Suerte { get => suerte; set => suerte = value; }
        public int Vida { get => vida; set => vida = value; }
        public string Salud { get => salud; set => salud = value; }


        public List<Personaje> ListaDePersonajes()
        {
            List <Personaje> personajes = new List<Personaje>()
            {
                new Personaje ("Juan",9),
                new Personaje ("Favalli",8),
                new Personaje ( "Elena" ,9), 
                new Personaje("Lucas",7),
                new Personaje("Polski",6)
            };

            return personajes;  
        }

        //public void ConsumirHambre()
        //{
        //    if

        //}
    }
}
