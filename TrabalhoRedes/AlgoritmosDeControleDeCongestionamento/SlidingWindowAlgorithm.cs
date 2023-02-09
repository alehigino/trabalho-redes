namespace TrabalhoRedes.AlgoritmosDeControleDeCongestionamento
{
    public static class SlidingWindowAlgorithm
    {
        public static void Main()
        {
            Console.WriteLine("Algoritmos de controle de congestionamento:");

            int windowSize = 10;
            int currentWindowSize = 0;
            int packetsSent = 0;

            while (packetsSent < 100)
            {
                while (currentWindowSize < windowSize)
                {
                    Console.WriteLine("Pacote enviado. Total de pacotes enviados: " + (++packetsSent));
                    currentWindowSize++;
                }

                Console.WriteLine("Aguardando confirmação de recebimento...");
                currentWindowSize = 0;
            }
        }
    }
}
