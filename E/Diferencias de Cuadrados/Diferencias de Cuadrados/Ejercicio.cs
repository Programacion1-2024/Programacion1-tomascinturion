﻿namespace Diferencias_de_Cuadrados
{

    /*
        Consigna: 
            Encuentra la diferencia entre el cuadrado de la suma y la suma de los cuadrados de los primeros N números naturales.

            El cuadrado de la suma de los diez primeros números naturales es (1 + 2 +... + 10)² = 55² = 3025.

            La suma de los cuadrados de los diez primeros números naturales es 1² + 2² +... + 10² = 385.

            Por tanto, la diferencia entre el cuadrado de la suma de los primeros diez números naturales y la suma de los cuadrados de los primeros diez números naturales es 3025 - 385 = 2640.

            No se espera que usted mismo descubra una solución eficaz a este problema desde los primeros principios; Se permite, o incluso se fomenta, la investigación. Encontrar el mejor algoritmo para el problema es una habilidad clave en ingeniería de software.

            Este ejercicio requiere que procese una recopilación de datos. Puede simplificar su código utilizando LINQ (Language Integrated Query).

            TIPS: Función Math.Pow, LINQ
    */

    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            int sum = Enumerable.Range(1, max).Sum();
            int elev = (int)Math.Pow(sum, 2);
            return elev;
        }

        public static int CalculateSumOfSquares(int max)
        {
            int sumaCuadrados = 0;

            for (int i = 1; i <= max; i++)
            {
                sumaCuadrados += (int)Math.Pow(i, 2);
            }

            return sumaCuadrados;
        }

        public static int CalculateDifferenceOfSquares(int max)
        {
            int result = CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
            return result;
            

        }
    }
}
