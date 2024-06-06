namespace ExamenFinalpr3
{
    public class Dispositivos
    {
        public int numerodeserie { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public Dispositivos()
        {
            numerodeserie = 0;
            marca = string.Empty;
            modelo = string.Empty;
        }
    }
}
