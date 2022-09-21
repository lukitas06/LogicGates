namespace LogicGates
{
    public class Compuertas:ICompuertas
    {   
        
        public IDictionary<string, int> Entradas = new Dictionary<string, int>();

        public void AgregarEntrada(string nombre,int valor)
        {
            if(!Entradas.ContainsKey(nombre)){
                Entradas.Add(nombre, valor);
            }
        }

        public void AgregarEntrada(string nombre, ICompuertas entrada)
        {
            if(!Entradas.ContainsKey(nombre)){
                Entradas.Add(nombre, entrada.CalcularSalida());
            }
        }
        
        public void ValidarEntradas()
        {   
            
            if(Entradas.Values.Count()<2)
            {
                throw new InvalidEntries("El numero de entradas es incorrecto.");
            }
        }

        public virtual int CalcularSalida()
        {
            return 0;
        }
    }
    
        
}