namespace TrabalhoRedes.AlgoritmoDoBaldeComToken
{
    public class TokenBucket
    {
        private int _currentTokens;

        public TokenBucket(int bucketSize)
        {
            _currentTokens = bucketSize;
        }

        public bool TryTakeToken()
        {
            int previousValue = Interlocked.Decrement(ref _currentTokens);
            if (previousValue >= 0)
            {
                return true;
            }
            else
            {
                Interlocked.Increment(ref _currentTokens);
                return false;
            }
        }
    }
}
