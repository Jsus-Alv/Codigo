class GenerarMatriz
{
    public static int[,] Generar(int filas, int columnas)
    {
        // Se crea una matriz bidimensional
        int[,] matriz = new int[filas, columnas];
        Random random = new Random();

        // Se generan los valores aleatorios para la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = random.Next(1, 101); // Estos valores seran numeros entre 0 y 100
            }
        }
        return matriz;
    }
}
