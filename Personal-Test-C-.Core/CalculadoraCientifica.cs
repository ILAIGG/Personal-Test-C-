namespace Personal_Test_C_.Core;

using Personal_Test_C_.Core;

public class CalculadoraCientifica : Calculadora
{

    public double Potencia(float baseNum, float exponente) => Math.Pow(baseNum, exponente);

    public double RaizCuadrada(int numero) => Math.Sqrt(numero);
}