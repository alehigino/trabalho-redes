namespace TrabalhoRedes.RoteamentoBaseadoNoFluxo
{
    public class Router
    {
        public string Name { get; set; } = "";
        public int Bandwidth { get; set; }
        public int Latency { get; set; }

        public Router() { }

        public Router(string name, int bandwidth, int latency)
        {
            Name = name;
            Bandwidth = bandwidth;
            Latency = latency;
        }
    }
}
