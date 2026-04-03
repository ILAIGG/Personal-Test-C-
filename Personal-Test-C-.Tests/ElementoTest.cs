using System.Runtime.CompilerServices;
using Personal_Test_C_.Core;
using Xunit;

namespace Personal_Test_C_.Tests;

public class ElementoTest
{
    [Fact]
    private void Elemento_Existencia_UnElemento()
    {
        Elemento banana = new(
            "Banana",
            23f,
            1.2f,
            0.2f,
            0.4f,
            3f,
            6.1f,
            0f,
            7f,
            0.4f,
            2.6f,
            348f,
            74.8f
        );

        Assert.NotNull(banana);
    }

    [Fact]
    private void Elemento_Existencia_ValorDeVariables()
    {
        Elemento banana = new(
            "Banana",
            23f,
            1.2f,
            0.2f,
            0.4f,
            3f,
            6.1f,
            0f,
            7f,
            0.4f,
            2.6f,
            348f,
            74.8f
        );

        Assert.Equal(23f, banana.Hg);
    }
}