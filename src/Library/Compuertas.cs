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

        public virtual int CalcularSalida()
        {
            return 0;
        }
    }    
}