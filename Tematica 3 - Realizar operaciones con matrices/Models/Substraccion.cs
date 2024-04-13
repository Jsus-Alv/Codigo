#nullable disable

class Substraccion
{
    public static double[,] RestarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas1 = matriz1.GetLength(0);
        int columnas1 = matriz1.GetLength(1);
        int filas2 = matriz2.GetLength(0);
        int columnas2 = matriz2.GetLength(1);

        if (filas1 != filas2 || columnas1 != columnas2)
        {
            return null;
        }

        double[,] resultado = new double[filas1, columnas1];

        double[,] raizCuadradaMatriz2 = IterativoMatriz.CalcularRaizCuadrada(matriz2);

        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas1; j++)
            {
                resultado[i, j] = matriz1[i, j] - raizCuadradaMatriz2[i, j];
            }
        }

        return resultado;
    }
}
