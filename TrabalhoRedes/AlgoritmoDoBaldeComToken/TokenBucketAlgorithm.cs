namespace TrabalhoRedes.AlgoritmoDoBaldeComToken
{
    public static class TokenBucketAlgorithm
    {
        public static void Main()
        {
            Console.WriteLine("Algoritmo do balde com token:");

            TokenBucket bucket = new(10);

            for (int i = 0; i < 20; i++)
            {
                if (bucket.TryTakeToken())
                {
                    Console.WriteLine("Token taken: " + i);
                }
                else
                {
                    Console.WriteLine("No tokens available: " + i);
                }
                Thread.Sleep(500);
            }
        }
    }
}
