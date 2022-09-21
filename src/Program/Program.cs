using LogicGates;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicAND and1 = new LogicAND("and-1");
            and1.AgregarEntrada("entrada 1", 1);
            and1.AgregarEntrada("entrada 2", 0);

            
            LogicOr or1 = new LogicOr("or-1");
            or1.AgregarEntrada("entrada 1", 0);
            or1.AgregarEntrada("entrada 2", and1);

            LogicNot not1= new LogicNot("not-1");
            not1.AgregarEntrada("entrada 1",or1);

            
             Console.WriteLine("Salida: " + not1.CalcularSalida());
        }
    }
}
