namespace Personal_Test_C_.Core;

public abstract class CalculadoraBase
{
    protected readonly ICalculadorProporcional _calculador;

    protected CalculadoraBase(ICalculadorProporcional calculador)
    {
        //Esto de acá tira directamente el error "ArgumentNullException" (osea, error de valor) si el nombre está o no vacío
        _calculador = calculador ?? throw new ArgumentNullException(nameof(calculador));
    }
}