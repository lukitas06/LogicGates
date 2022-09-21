using System;


namespace LogicGates
{
public class LogicAND : Compuertas
{   
    private string Name;
    public LogicAND(string name){
        this.Name=name;
    }

    public string getNombre(){
        return this.Name;
    }

    public override int CalcularSalida()
    {
        int salida = 1;
        ValidarEntradas();
        foreach (var entrada in Entradas.Values){
            Console.WriteLine(this.Name + " entrada: " + entrada);
           salida = salida * entrada;
        }

        return salida;
    }
}

}
