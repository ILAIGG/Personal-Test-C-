using System.Collections.Generic;

namespace Personal_Test_C_.Core;

public interface ICalculadoraNutricional
{
    List<object> CalcularPorcion(Elemento elemento, float gramos);
    List<object> CalcularPorcion(Elemento elemento, int gramos);
}