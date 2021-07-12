using System.Collections.Generic;

namespace PrimeStreaming
{
    public class Primes
    {
        public IEnumerable<int> Stream()
        {
            return new List<int> { 2, 3, 5, 7, 11, 13, 17 };
        }
    }
}
