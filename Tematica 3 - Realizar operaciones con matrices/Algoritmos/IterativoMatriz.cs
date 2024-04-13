class IterativoMatriz // Algoritmo Iterativo
{
    public static double[,] CalcularRaizCuadrada(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        
        double[,] resultado = new double[filas, columnas];
        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = CalcularRaizCuadradaIterativa(matriz[i, j]);
            }
        }
        
        return resultado;
    }

    private static double CalcularRaizCuadradaIterativa(int valor)
    {
        double aproximacion = valor / 2.0;
        double diferencia = aproximacion * aproximacion - valor;
        
        while (Math.Abs(diferencia) > 0.00001)
        {
            aproximacion = (aproximacion + valor / aproximacion) / 2;
            diferencia = aproximacion * aproximacion - valor;
        }
        
        return aproximacion;
    }
}
