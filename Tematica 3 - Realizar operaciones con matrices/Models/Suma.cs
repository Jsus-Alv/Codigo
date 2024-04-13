#nullable disable

class Suma
{
    public static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        int filas1 = matriz1.GetLength(0);
        int columnas1 = matriz1.GetLength(1);
        int filas2 = matriz2.GetLength(0);
        int columnas2 = matriz2.GetLength(1);

        // Verificar si son conformables para la suma
        if (filas1 != filas2 || columnas1 != columnas2)
        {
            return null;
        }

        int[,] resultado = new int[filas1, columnas1];

        for (int i = 0; i < filas1; i++)
        {
            for (int j = 0; j < columnas1; j++)
            {
                resultado[i, j] = 3 * matriz1[i, j] + 4 * matriz2[i, j];
            }
        }

        OrdenarMatriz ordenarMatriz = new OrdenarMatriz();
        ordenarMatriz.Ordenar(resultado);

        return resultado;
    }
}
