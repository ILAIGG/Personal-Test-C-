using Personal_Test_C_.Core;
using Xunit;

namespace Personal_Test_C_.Tests;

public class CalculadoraTests
{
    //"[Fact]" Esto indica que este método es una prueba. USAR AL
    //INICIO DE TODOS LOS MÉTODOS DE TESTSSSSSS!!!!!!!!
    [Fact] 
    public void Sumar_CuandoSeLlamanDosNumeros_RetornoSuma()
    {
        var calc = new Calculadora();

        var resultado = calc.Sumar(5, 5);

        Assert.Equal(10, resultado);
    }
}

