using System.Text.RegularExpressions;

namespace ExamenFinalpr3
{
    public class Smartphone: Dispositivos
    {
        string Sistemaop { get; set; }
        int Numerodecamaras { get; set; }

        public Smartphone()
        {
            Sistemaop = string.Empty;
            Numerodecamaras = 0;
        }

    }
}
