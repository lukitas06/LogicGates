using System;

namespace LogicGates
{
    public class LogicNot:Compuertas
    {
        private string Name;
        
        public LogicNot(string name)
        {
            this.Name=name;
        }
        public string getNombre()
        {
            return this.Name;
        }
        new public void ValidarEntradas()
        {   
            
            if(Entradas.Values.Count()>1)
            {
                throw new InvalidEntries("El numero de entradas es incorrecto.");
            }
        }

        public override int CalcularSalida()
        {
            int salida=1;
            ValidarEntradas();
            
            foreach(var entrada in Entradas.Values)
            {
            if(entrada==1)
            {
                salida=0;
            }
            else salida=1;
            }
            return salida;
        }
    }

}