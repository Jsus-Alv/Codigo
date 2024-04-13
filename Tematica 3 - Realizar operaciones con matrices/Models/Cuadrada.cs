class Cuadrada
{
    public static (bool esMatriz1Simetrica, bool esMatriz2Simetrica) VerificarSimetria(int[,] matriz1, int[,] matriz2)
    {
        // Verifica si ambas son cuadradas
        if (matriz1.GetLength(0) != matriz1.GetLength(1) || matriz2.GetLength(0) != matriz2.GetLength(1))
        {
            return (false, false);
        }

        int n1 = matriz1.GetLength(0);
        int n2 = matriz2.GetLength(0);

        // Verifica si la Matriz 1 es simetrica
        bool esMatriz1Simetrica = RecursivoMatriz.EsSimetrica(matriz1, n1);

        // Verifica si la Matriz 2 es simetrica
        bool esMatriz2Simetrica = RecursivoMatriz.EsSimetrica(matriz2, n2);

        return (esMatriz1Simetrica, esMatriz2Simetrica);
    }
}
