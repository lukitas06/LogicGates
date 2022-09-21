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

        public override int CalcularSalida()
        {
            int salida=1;
            
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