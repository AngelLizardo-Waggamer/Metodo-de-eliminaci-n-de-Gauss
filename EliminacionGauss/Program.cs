/*
    Autor: Ángel Andrés Hernández Lizardo (@AngelLizardo-Waggamer)
    Fecha: 26/02/2025
    Descripción: Programa para resolver sistemas de ecuaciones lineales mediante el método de eliminación de Gauss.
*/

/*
    Ecuaciones:
    2x + y - z = 1
    3x + 2y + 2z = 12
    x + y + z = 5

    Respuestas esperadas:
    x1 = 2
    x2 = 0
    x3 = 3
*/
double[,] a = { { 2, 1, -1 },
                { 3, 2, 2 },
                { 1, 1, 1 } }; // Variables
double[] b = { 1, 12, 5 }; // Respuestas
int n = 3; // Número de variables|ecuaciones

for (int i = 0; i < n; i++)
{
    for (int k = i + 1; k < n; k++)
    {
        double t = a[k, i] / a[i, i];
        for (int j = 0; j < n; j++)
        {
            a[k, j] -= t * a[i, j];
        }
        b[k] -= t * b[i];
    }
}

double[] x = new double[n];
for (int i = n - 1; i >= 0; i--)
{
    x[i] = b[i];
    for (int j = i + 1; j < n; j++)
    {
        x[i] -= a[i, j] * x[j];
    }
    x[i] /= a[i, i];
}

Console.WriteLine("Soluciones:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine("x" + (i + 1) + " = " + x[i]);
}