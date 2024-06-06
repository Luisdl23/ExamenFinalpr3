using System.Globalization;

namespace ExamenFinalpr3
{
    public class Tablet:Dispositivos
    {
        int Tamaniopantalla { get; set; }
        string SoporteparaStylus { get; set; }

        public Tablet()
        {
            Tamaniopantalla = 0;
            SoporteparaStylus = string.Empty;
        }
    }
}
