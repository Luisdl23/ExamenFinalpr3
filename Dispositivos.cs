namespace ExamenFinalpr3
{
    public class Dispositivos
    {
        int numerodeserie { get; set; }
        string marca { get; set; }
        int modelo { get; set; }

        public Dispositivos()
        {
            numerodeserie = 0;
            marca = string.Empty;
            modelo = 0;
        }
    }
}
