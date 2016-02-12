function solve() {
    return function primeNumbersInARange(start, end) {
        var sieve = [],
            i,
            j,
            primes = [];
        if (isNaN(+start) && isNaN(+end)) {
            throw 'Not a digit!'
        }
        if (start === undefined || end === undefined) {
            throw 'Missing parameter!'
        }
        for (i = 2; i <= end; i += 1) {
            if (!sieve[i]) {
                primes.push(i);
                for (j = i << 1; j <= end; j += i) {
                    sieve[j] = true;
                }
            }
        }
        var temp = [],
            len = primes.length;
        for (i = 0; i < len; i += 1) {
            if (primes[i] >= start) {
                temp.push(primes[i])
            }
        }
        return temp;
    }
}