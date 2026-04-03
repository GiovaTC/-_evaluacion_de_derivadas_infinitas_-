using System;

public class DerivadaEvaluator
{
    public static string Evaluar(double numerador, double denominador)
    {
        string resultado;

        if (!double.IsNaN(numerador) && !double.IsNaN(denominador))
        {
            if (Math.Abs(denominador) < 0.000001)
            {
                if (Math.Abs(numerador) > 0)
                {
                    resultado = "INFINITA";
                }
                else
                {
                    resultado = "INDETERMINADA";
                }
            }
            else
            {
                resultado = "FINITA";
            }
        }
        else
        {
            resultado = "INDETERMINADA";
        }

        return resultado;
    }
}