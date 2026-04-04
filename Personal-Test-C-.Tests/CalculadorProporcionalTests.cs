using Personal_Test_C_.Core;
using Xunit;

namespace Personal_Test_C_.Tests;

public class CalculadorProporcionalTests
{
    [Fact]
    public void CalcularProporcion_CalculaCorrectamente()
    {
        var calculador = new CalculadorProporcionalSimple();
        float valorBase = 20f;
        float cantidad = 50f;

        float resultado = calculador.CalcularProporcion(valorBase, cantidad);

        Assert.Equal(10f, resultado); //(20 * 50) / 100 = 10
    }

    [Fact]
    public void CalcularProporcion_CantidadCero_RetornaCero()
    {
        var calculador = new CalculadorProporcionalSimple();
        float valorBase = 100f;
        float cantidad = 0f;

        float resultado = calculador.CalcularProporcion(valorBase, cantidad);

        Assert.Equal(0f, resultado);
    }

    [Fact]
    public void CalcularProporcion_ValorBaseCero_RetornaCero()
    {
        var calculador = new CalculadorProporcionalSimple();
        float valorBase = 0f;
        float cantidad = 200f;

        float resultado = calculador.CalcularProporcion(valorBase, cantidad);

        Assert.Equal(0f, resultado);
    }
}