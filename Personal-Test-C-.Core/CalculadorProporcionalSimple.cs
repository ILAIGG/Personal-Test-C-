namespace Personal_Test_C_.Core;

public class CalculadorProporcionalSimple : ICalculadorProporcional
{
    public float CalcularProporcion(float valorBase, float cantidad)
    {
        return (valorBase * cantidad) / 100.0f;
    }
}