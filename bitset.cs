public static BitSet computePrimes(int limit)
{
    final BitSet primes = new BitSet();
    primes.set(0, false);
    primes.set(1, false);
    primes.set(2, limit, true);
    for (int i = 0; i * i < limit; i++)
    {
        if (primes.get(i))
        {
            for (int j = i * i; j < limit; j += i)
            {
                primes.clear(j);
            }
        }
    }
    return primes;
}
