using System.Collections.Generic;

namespace Personal_Test_C_.Core;

public class CalculadoraNutricional
{
    public List<object> CalcularPorcion(Elemento elemento, float gramos)
    {
        float factor = gramos / 100.0f;
        return new List<object>
        {
            elemento.Name,
            gramos,
            elemento.Hg * factor,
            elemento.Pts * factor,
            elemento.Lp * factor,
            elemento.Na * factor,
            elemento.VitA * factor,
            elemento.VitC * factor,
            elemento.VitD * factor,
            elemento.Ca * factor,
            elemento.Fe * factor,
            elemento.Fibra * factor,
            elemento.Potasio * factor,
            elemento.Agua * factor
        };
    }
}