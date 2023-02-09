namespace TrabalhoRedes.AlgoritmoComVetorDeDistancia
{
    public static class AlgorithmWithDistanceVector
    {
        public static void Main()
        {
            Console.WriteLine("Algoritmo com vetor de distância:");

            var vectorA = new double[] { 1, 2, 3 };
            var vectorB = new double[] { 4, 5, 6 };

            Console.WriteLine("A distância Euclidiana entre os vetores é: " + EuclideanDistance(vectorA, vectorB));
        }

        private static double EuclideanDistance(double[] vectorA, double[] vectorB)
        {
            double sum = 0;

            for (int i = 0; i < vectorA.Length; i++)
            {
                sum += Math.Pow(vectorA[i] - vectorB[i], 2);
            }

            return Math.Sqrt(sum);
        }
    }
}
