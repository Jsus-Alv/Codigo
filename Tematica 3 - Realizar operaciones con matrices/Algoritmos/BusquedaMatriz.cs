class BusquedaMatriz // Algoritmo de Busqueda
{
    public static (int, int)? BuscarValor(double[,] matriz, double valorBuscado)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == valorBuscado)
                {
                    return (i, j);
                }
            }
        }

        return null;
    }
}
