namespace TrabalhoRedes.RoteamentoBaseadoNoFluxo
{
    public class Flow
    {
        public int DataSize { get; set; }
        public List<Router> Routers { get; set; }

        public Flow(int dataSize, List<Router> routers)
        {
            DataSize = dataSize;
            Routers = routers;
        }

        public string GetBestRoute()
        {
            Router bestRouter = new ();
            int bestScore = int.MaxValue;

            foreach (Router router in Routers)
            {
                int score = (router.Bandwidth - DataSize) + (2 * router.Latency);

                if (score < bestScore)
                {
                    bestScore = score;
                    bestRouter = router;
                }
            }

            return bestRouter.Name;
        }
    }
}
