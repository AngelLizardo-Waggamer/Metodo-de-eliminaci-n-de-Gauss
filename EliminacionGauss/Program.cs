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
double[,] coeficientes = {  { 2, 1, -1 },  // Matriz de coeficientes
                            { 3, 2, 2 },   
                            { 1, 1, 1 } }; 
double[] valoresRespuesta = { 1, 12, 5 };  // Matriz de respuestas de las ecuaciones
int gradoDelSistema = 3; // Grado del sistema de ecuaciones. Es decir, el número de ecuacionnes y de respuestas.

for (int i = 0; i < gradoDelSistema; i++)
{
    for (int k = i + 1; k < gradoDelSistema; k++)
    {
        double t = coeficientes[k, i] / coeficientes[i, i];
        for (int j = 0; j < gradoDelSistema; j++)
        {
            coeficientes[k, j] -= t * coeficientes[i, j];
        }
        valoresRespuesta[k] -= t * valoresRespuesta[i];
    }
}

double[] x = new double[gradoDelSistema];
for (int i = gradoDelSistema - 1; i >= 0; i--)
{
    x[i] = valoresRespuesta[i];
    for (int j = i + 1; j < gradoDelSistema; j++)
    {
        x[i] -= coeficientes[i, j] * x[j];
    }
    x[i] /= coeficientes[i, i];
}

Console.WriteLine("Soluciones:");
for (int i = 0; i < gradoDelSistema; i++)
{
    Console.WriteLine("x" + (i + 1) + " = " + x[i]);
}