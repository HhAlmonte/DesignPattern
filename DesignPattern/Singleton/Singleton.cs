namespace DesignPattern.Singleton
{
    /*
     * Singleton
     * 
     * El patron singleton es un patron de diseño creacional que permite asegurar que una clase tenga solo una
     * instancia, y proporciona un punto de acceso global a ella.
     * 
     * El patron singleton es muy simple de implementar. Solo debemos asegurarnos de que la clase tenga un
     * constructor privado, un metodo estatico de creacion que actue como un constructor y un campo estatico
     * que almacene la instancia de la clase.
     */
    
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        
        private Singleton()
        {
        }

        
    }
}
