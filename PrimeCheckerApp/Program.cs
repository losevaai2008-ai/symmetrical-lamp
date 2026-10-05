namespace PrimeCheckerApp;

public class PrimeChecker
{
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;      // 0, 1 и отрицательные — не простые
        if (n == 2) return true;       // 2 — единственное чётное простое
        if (n % 2 == 0) return false;  // остальные чётные — составные

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}

