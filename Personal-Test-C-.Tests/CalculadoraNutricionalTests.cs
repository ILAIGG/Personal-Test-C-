using Personal_Test_C_.Core;
using Xunit;

namespace Personal_Test_C_.Tests;

public class CalculadoraNutricionalTests
{
    [Fact]
    public void CalcularPorcion_CalculaCorrectamentePara50Gramos()
    {
        var calc = new CalculadoraNutricional(new CalculadorProporcionalSimple());
        var elemento = new Elemento("Banana", 10f, 5f, 2f, 1f, 3f, 4f, 0.5f, 6f, 0.8f, 2.5f, 7f, 8f);
        float gramos = 50f;

        var resultado = calc.CalcularPorcion(elemento, gramos);

        Assert.Equal("Banana", resultado[0]);
        Assert.Equal(50f, resultado[1]);
        Assert.Equal(5f, resultado[2]); //Hg: 10 * 0.5
        Assert.Equal(2.5f, resultado[3]); //Pts: 5 * 0.5
        Assert.Equal(1f, resultado[4]); //Lp: 2 * 0.5
        Assert.Equal(0.5f, resultado[5]); //Na: 1 * 0.5
        Assert.Equal(1.5f, resultado[6]); //VitA: 3 * 0.5
        Assert.Equal(2f, resultado[7]); //VitC: 4 * 0.5
        Assert.Equal(0.25f, resultado[8]); //VitD: 0.5 * 0.5
        Assert.Equal(3f, resultado[9]); //Ca: 6 * 0.5
        Assert.Equal(0.4f, resultado[10]); //Fe: 0.8 * 0.5
        Assert.Equal(1.25f, resultado[11]); //Fibra: 2.5 * 0.5
        Assert.Equal(3.5f, resultado[12]); //Potasio: 7 * 0.5
        Assert.Equal(4f, resultado[13]); //Agua: 8 * 0.5
    }

    [Fact]
    public void CalcularPorcion_CalculaCorrectamentePara100Gramos()
    {
        var calc = new CalculadoraNutricional(new CalculadorProporcionalSimple());
        var elemento = new Elemento("Manzana", 20f, 10f, 4f, 2f, 6f, 8f, 1f, 12f, 1.6f, 5f, 14f, 16f);
        float gramos = 100f;

        var resultado = calc.CalcularPorcion(elemento, gramos);

        Assert.Equal("Manzana", resultado[0]);
        Assert.Equal(100f, resultado[1]);
        Assert.Equal(20f, resultado[2]); //Hg sin cambio
        Assert.Equal(10f, resultado[3]);
        Assert.Equal(4f, resultado[4]);
        Assert.Equal(2f, resultado[5]);
        Assert.Equal(6f, resultado[6]);
        Assert.Equal(8f, resultado[7]);
        Assert.Equal(1f, resultado[8]);
        Assert.Equal(12f, resultado[9]);
        Assert.Equal(1.6f, resultado[10]);
        Assert.Equal(5f, resultado[11]);
        Assert.Equal(14f, resultado[12]);
        Assert.Equal(16f, resultado[13]);
    }

    [Fact]
    public void CalcularPorcion_CalculaCorrectamentePara25Gramos()
    {
        var calc = new CalculadoraNutricional(new CalculadorProporcionalSimple());
        var elemento = new Elemento("Naranja", 15f, 7.5f, 3f, 1.5f, 4.5f, 6f, 0.75f, 9f, 1.2f, 3.75f, 10.5f, 12f);
        float gramos = 25f;

        var resultado = calc.CalcularPorcion(elemento, gramos);

        Assert.Equal("Naranja", resultado[0]);
        Assert.Equal(25f, resultado[1]);
        Assert.Equal(3.75f, resultado[2]); //15 * 0.25
        Assert.Equal(1.875f, resultado[3]); //7.5 * 0.25
        Assert.Equal(0.75f, resultado[4]); //3 * 0.25
        Assert.Equal(0.375f, resultado[5]); //1.5 * 0.25
        Assert.Equal(1.125f, resultado[6]); //4.5 * 0.25
        Assert.Equal(1.5f, resultado[7]); //6 * 0.25
        Assert.Equal(0.1875f, resultado[8]); //0.75 * 0.25
        Assert.Equal(2.25f, resultado[9]); //9 * 0.25
        Assert.Equal(0.3f, resultado[10]); //1.2 * 0.25
        Assert.Equal(0.9375f, resultado[11]); //3.75 * 0.25
        Assert.Equal(2.625f, resultado[12]); //10.5 * 0.25
        Assert.Equal(3f, resultado[13]); //12 * 0.25
    }

    [Fact]
    public void CalcularPorcion_IntOverload_CalculaCorrectamente()
    {
        var calc = new CalculadoraNutricional(new CalculadorProporcionalSimple());
        var elemento = new Elemento("Pera", 12f, 6f, 2.4f, 1.2f, 3.6f, 4.8f, 0.6f, 7.2f, 0.96f, 3f, 8.4f, 9.6f);
        int gramos = 75;

        var resultado = calc.CalcularPorcion(elemento, gramos);

        Assert.Equal("Pera", resultado[0]);
        Assert.Equal(75f, resultado[1]); //convertido a float
        Assert.Equal(9f, resultado[2]); //12 * 0.75
    }

    [Fact]
    public void Elemento_Constructor_ValidaValoresNegativos_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() => new Elemento("Test", -1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f));
    }

    [Fact]
    public void Elemento_Constructor_ValidaNombreVacio_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() => new Elemento("", 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f));
    }

    [Fact]
    public void Elemento_Constructor_ValidaPtsNegativo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentException>(() => new Elemento("Test", 0f, -1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f));
    }

    [Fact]
    public void Elemento_Constructor_ValidaTodosValoresPositivos_NoLanzaExcepcion()
    {
        var elemento = new Elemento("Valido", 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
        Assert.Equal("Valido", elemento.Name);
        Assert.Equal(1f, elemento.Hg);
    }

    [Fact]
    public void CalculadoraNutricional_Constructor_CalculadorNulo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentNullException>(() => new CalculadoraNutricional(null));
    }

    [Fact]
    public void CalcularPorcion_UsaCalculadorProporcional_Correctamente()
    {
        //Utiliza un mock o implementación simple para verificar que se llama al calculador
        var calculador = new CalculadorProporcionalSimple();
        var calc = new CalculadoraNutricional(calculador);
        var elemento = new Elemento("Test", 10f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
        float gramos = 50f;

        var resultado = calc.CalcularPorcion(elemento, gramos);

        //Verifica que el primer valor calculado es correcto
        Assert.Equal(5f, resultado[2]); //Hg: 10 * 0.5
    }

    [Fact]
    public void CalcularPorcion_IntOverload_ConvierteCorrectamente()
    {
        var calc = new CalculadoraNutricional(new CalculadorProporcionalSimple());
        var elemento = new Elemento("Test", 8f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
        int gramos = 25;

        var resultado = calc.CalcularPorcion(elemento, gramos);

        Assert.Equal(25f, resultado[1]); // Convertido a float
        Assert.Equal(2f, resultado[2]); // 8 * 0.25
    }
}