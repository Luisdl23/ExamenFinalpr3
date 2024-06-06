using System.Globalization;

namespace ExamenFinalpr3
{
    public class Tablet : Dispositivos
    {
        public int Tamaniopantalla { get; set; }
        public string SoporteparaStylus { get; set; }

        public Tablet()
        {
            Tamaniopantalla = 0;
            SoporteparaStylus = string.Empty;
        }
    }
}
