using System;

namespace LogicGates
{
    public class LogicOr:Compuertas
    {
        private string Name;

        public LogicOr(string name)
        {
            this.Name=name;
        }

        public string getNombre()
        {
            return this.Name;
        }

        public override int CalcularSalida()
        {
            int salida=0;
            if(Entradas.Values.Contains(1))
            {
                salida=1;
            }
            else salida=0;
            
            return salida;
        }
    }

}