using Personal_Test_C_.Core;
using Xunit;

namespace Personal_Test_C_.Tests;

public class CalculadoraTests
{
    //"[Fact]" Esto indica que este método es una prueba. USAR AL
    //INICIO DE TODOS LOS MÉTODOS DE TESTSSSSSS!!!!!!!!
    [Fact] 
    public void Calculadora_Sumar_DosNumeros()
    {
        var calc = new Calculadora();

        var resultado = calc.Sumar(5, 5);

        Assert.Equal(10, resultado);
    }

    [Fact] 
    public void Calculcadora_Restar_DosNumeros()
    {
        var calc = new Calculadora();

        var resultado = calc.Restar(20, 5);

        Assert.Equal(15, resultado);
    }

    [Fact] 
    public void Calculcadora_Multiplicar_DosNumeros()
    {
        var calc = new Calculadora();

        var resultado = calc.Multiplicar(5, 5);

        Assert.Equal(25, resultado);
    }

    [Fact] 
    public void Calculcadora_Dividir_DosNumeros()
    {
        var calc = new Calculadora();

        var resultado = calc.Dividir(4, 2);

        Assert.Equal(2, resultado);
    }

    [Fact] 
    public void CalculadoraCientifica_Sumar_DosNumeros_ConHerencia()
    {
        var calc = new CalculadoraCientifica();

        var resultado = calc.Sumar(50, 50);

        Assert.Equal(100, resultado);
    }

    [Fact] 
    public void CalculadoraCientifica_Potencia_DosNumeros()
    {
        var calc = new CalculadoraCientifica();

        var resultado = calc.Potencia(5, 2);

        Assert.Equal(25, resultado);
    }

    [Fact] 
    public void CalculadoraCientifica_RaizCuadrada_UnNumero()
    {
        var calc = new CalculadoraCientifica();

        var resultado = calc.RaizCuadrada(9);

        Assert.Equal(3, resultado);
    }
}

