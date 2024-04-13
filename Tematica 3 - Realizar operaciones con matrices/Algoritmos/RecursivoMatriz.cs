class RecursivoMatriz // Algoritmo Recursivo
{
    public static bool EsSimetrica(int[,] matriz, int n, int i = 0, int j = 0)
    {
        if (i == n)
        {
            return true;
        }
        
        if (matriz[i, j] != matriz[j, i])
        {
            return false;
        }

        if (j + 1 < n)
        {
            return EsSimetrica(matriz, n, i, j + 1);
        }
        else
        {
            return EsSimetrica(matriz, n, i + 1, 0);
        }
    }
}
