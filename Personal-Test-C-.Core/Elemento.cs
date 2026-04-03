namespace Personal_Test_C_.Core;

public class Elemento
{
    public string Name { get; private set; }
    public float Hg { get; private set; }
    public float Pts { get; private set; }
    public float Lp { get; private set; }
    public float Na { get; private set; }
    public float VitA { get; private set; }
    public float VitC { get; private set; }
    public float VitD { get; private set; }
    public float Ca { get; private set; }
    public float Fe { get; private set; }
    public float Fibra { get; private set; }
    public float Potasio { get; private set; }
    public float Agua { get; private set; }

    public Elemento(string name, float hg, float pts, float lp, float na, 
                    float vitA, float vitC, float vitD, float ca, float fe, 
                    float fibra, float potasio, float agua)
    {
        Name = name;
        Hg = hg;
        Pts = pts;
        Lp = lp;
        Na = na;
        VitA = vitA;
        VitC = vitC;
        VitD = vitD;
        Ca = ca;
        Fe = fe;
        Fibra = fibra;
        Potasio = potasio;
        Agua = agua;
    }
}