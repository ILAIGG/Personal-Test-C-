using System.Collections.Generic;

namespace Personal_Test_C_.Core;

public class CalculadoraNutricional : CalculadoraBase, ICalculadoraNutricional
{
    public CalculadoraNutricional(ICalculadorProporcional calculador) : base(calculador) { }

    public List<object> CalcularPorcion(Elemento elemento, float gramos)
    {
        return new List<object>
        {
            elemento.Name,
            gramos,
            _calculador.CalcularProporcion(elemento.Hg, gramos),
            _calculador.CalcularProporcion(elemento.Pts, gramos),
            _calculador.CalcularProporcion(elemento.Lp, gramos),
            _calculador.CalcularProporcion(elemento.Na, gramos),
            _calculador.CalcularProporcion(elemento.VitA, gramos),
            _calculador.CalcularProporcion(elemento.VitC, gramos),
            _calculador.CalcularProporcion(elemento.VitD, gramos),
            _calculador.CalcularProporcion(elemento.Ca, gramos),
            _calculador.CalcularProporcion(elemento.Fe, gramos),
            _calculador.CalcularProporcion(elemento.Fibra, gramos),
            _calculador.CalcularProporcion(elemento.Potasio, gramos),
            _calculador.CalcularProporcion(elemento.Agua, gramos)
        };
    }

    //Sobrecarga pero ingresando int en vez de float (nomás lo convierte de int a float y ya)
    public List<object> CalcularPorcion(Elemento elemento, int gramos)
    {
        return CalcularPorcion(elemento, (float)gramos);
    }
}