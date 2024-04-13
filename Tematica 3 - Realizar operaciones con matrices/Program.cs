#nullable disable

class Program
{
    static void Main()
    {
        // Se le pide al usario que introduzca las dimensiones de la matriz 1
        Console.WriteLine("Introduzca las dimensiones de la primera matriz: ");

        Console.Write("\nFilas: ");
        int filas1 = int.Parse(Console.ReadLine());

        Console.Write("Columnas: ");
        int columnas1 = int.Parse(Console.ReadLine());

        // Se le pide al usario que introduzca las dimensiones de la matriz 2
        Console.WriteLine("\nIntroduzca las dimensiones de la segunda matriz: ");
        Console.Write("\nFilas: ");
        int filas2 = int.Parse(Console.ReadLine());
        Console.Write("Columnas: ");
        int columnas2 = int.Parse(Console.ReadLine());

        // Se generan las matrices
        int[,] matriz1 = GenerarMatriz.Generar(filas1, columnas1);
        int[,] matriz2 = GenerarMatriz.Generar(filas2, columnas2);

        Console.WriteLine("\nPrimera Matriz:");
        MostrarMatriz.Mostrar(matriz1);

        Console.WriteLine("\nSegunda Matriz:");
        MostrarMatriz.Mostrar(matriz2);

        Console.WriteLine("----------------------");

        // Suma
        Console.WriteLine("SUMA:");
        Console.WriteLine("\nResultado de 3 * Matriz1 + 4 * Matriz2:");
        int[,] resultadoSuma = Suma.SumarMatrices(matriz1, matriz2);

        if (resultadoSuma != null)
        {
            MostrarMatriz.Mostrar(resultadoSuma);

            Console.WriteLine("\nComplejidad Temporal: O(n * m)");
            Console.WriteLine("Complejidad Espacial: O(n * m)");

        }
        else
        {
            Console.WriteLine("Las matrices no son conformables para la suma.");
        }

        Console.WriteLine("----------------------"); // Solo usado para mejorar la lectura del codigo cuando se vea en consola

        // Multiplicación
        Console.WriteLine("MULTIPLICACION: ");
        var resultadosMultiplicacion = Multiplicacion.MultiplicarMatrices(matriz1, matriz2);

        double[,] resultadoLog = resultadosMultiplicacion.resultadoLog;
        double[,] resultadoRaizCubo = resultadosMultiplicacion.resultadoRaizCubo;

        if (resultadoLog != null)
        {
            Console.WriteLine("\nResultado de 2 * Matriz1 * log10(Matriz2):");
            MostrarMatriz.Mostrar(resultadoLog);

            Console.WriteLine("\nComplejidad Temporal: O(n * m * p)");
            Console.WriteLine("Complejidad Espacial: O(n * m + n * p)");

        }
        else
        {
            Console.WriteLine("\nLas matrices no son conformables para la multiplicación usando logaritmo");
        }

        if (resultadoRaizCubo != null)
        {
            Console.WriteLine("\nResultado de (Matriz1 ^ 3) * sqrt(Matriz2):");
            MostrarMatriz.Mostrar(resultadoRaizCubo);

            Console.WriteLine("\nComplejidad Temporal: O(n * m * p)");
            Console.WriteLine("Complejidad Espacial: O(n * m + n * p)");
        }
        else
        {
            Console.WriteLine("\nLas matrices no son conformables para la multiplicación usando raíz cuadrada y cubo");
        }

        Console.WriteLine("----------------------");

        // Substracción
        Console.WriteLine("SUBSTRACCION: ");
        Console.WriteLine("\nResultado de Matriz1 - sqrt(Matriz2):");
        double[,] resultadoSubstraccion = Substraccion.RestarMatrices(matriz1, matriz2);

        if (resultadoSubstraccion != null)
        {
            MostrarMatriz.Mostrar(resultadoSubstraccion);

            Console.WriteLine("\nComplejidad Temporal: O(n * m)");
            Console.WriteLine("Complejidad Espacial: O(n * m)");
        }
        else
        {
            Console.WriteLine("\nLas matrices no son conformables para la sustracción.");
        }

        Console.WriteLine("----------------------");

        // Cuadrada
        Console.WriteLine("\nVerificacion de simetria de matrices cuadradas:");

        var simetria = Cuadrada.VerificarSimetria(matriz1, matriz2);

        if (simetria.esMatriz1Simetrica && simetria.esMatriz2Simetrica)
        {
            Console.WriteLine("Ambas matrices son cuadradas y simétricas.");

            Console.WriteLine("\nComplejidad Temporal: O(n * n)");
            Console.WriteLine("Complejidad Espacial: O(1)");
        }
        else
        {
            if (!simetria.esMatriz1Simetrica && simetria.esMatriz2Simetrica)
            {
                Console.WriteLine("La Matriz 1 no es simetrica, pero la Matriz 2 si lo es");

                Console.WriteLine("\nComplejidad Temporal: O(n * n)");
                Console.WriteLine("Complejidad Espacial: O(1)");
            }
            else if (simetria.esMatriz1Simetrica && !simetria.esMatriz2Simetrica)
            {
                Console.WriteLine("La Matriz 1 es simetrica, pero la Matriz 2 no lo es");

                Console.WriteLine("\nComplejidad Temporal: O(n * n)");
                Console.WriteLine("Complejidad Espacial: O(1)");
            }
            else
            {
                Console.WriteLine("Ninguna de las matrices es simetrica.");
            }
        }
    }
}
