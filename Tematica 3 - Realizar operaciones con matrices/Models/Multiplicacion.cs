#nullable disable

class Multiplicacion
{
    public static (double[,] resultadoLog, double[,] resultadoRaizCubo) MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas1 = matriz1.GetLength(0);
        int columnas1 = matriz1.GetLength(1);
        int filas2 = matriz2.GetLength(0);
        int columnas2 = matriz2.GetLength(1);

        if (columnas1 != filas2)
        {
            return (null, null);
        }

        double[,] resultadoLog = new double[filas1, columnas2];
        double[,] resultadoRaizCubo = new double[filas1, columnas2];

        double[,] logMatriz2 = new double[filas2, columnas2];
        for (int i = 0; i < filas2; i++)
        {
            for (int j = 0; j < columnas2; j++)
            {
                logMatriz2[i, j] = Math.Log10(matriz2[i, j]);
            }
        }

        double[,] raizCuadradaMatriz2 = new double[filas2, columnas2];
        for (int i = 0; i < filas2; i++)
        {
            for (int j = 0; j < columnas2; j++)
            {
                raizCuadradaMatriz2[i, j] = Math.Sqrt(matriz2[i, j]);
            }
        }

        // (2 * Matriz1) * log10(Matriz2)
        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas2; j++)
            {
                resultadoLog[i, j] = 0;
                for (int k = 0; k < columnas1; k++)
                {
                    resultadoLog[i, j] += (2 * matriz1[i, k]) * logMatriz2[k, j];
                }
            }
        }

        // (Matriz1 ^ 3) * sqrt(Matriz2)
        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas2; j++)
            {
                resultadoRaizCubo[i, j] = 0;
                for (int k = 0; k < columnas1; k++)
                {
                    double cuboMatriz1 = Math.Pow(matriz1[i, k], 3);
                    resultadoRaizCubo[i, j] += cuboMatriz1 * raizCuadradaMatriz2[k, j];
                }
            }
        }

        return (resultadoLog, resultadoRaizCubo);
    }
}
