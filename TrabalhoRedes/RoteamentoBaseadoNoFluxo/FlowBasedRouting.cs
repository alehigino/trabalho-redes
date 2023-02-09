namespace TrabalhoRedes.RoteamentoBaseadoNoFluxo
{
    public static class FlowBasedRouting
    {
        public static void Main()
        {
            Console.WriteLine("Roteamento baseado no fluxo:");

            List<Router> routers = new();
            routers.Add(new Router("R1", 100, 20));
            routers.Add(new Router("R2", 75, 50));
            routers.Add(new Router("R3", 50, 40));

            Flow flow = new(500, routers);

            Console.WriteLine("A rota escolhida para o fluxo de dados é: " + flow.GetBestRoute());
        }
    }
}
