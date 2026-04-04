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
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be null or empty", nameof(name));
        if (hg < 0) throw new ArgumentException("Hg must be non-negative", nameof(hg));
        if (pts < 0) throw new ArgumentException("Pts must be non-negative", nameof(pts));
        if (lp < 0) throw new ArgumentException("Lp must be non-negative", nameof(lp));
        if (na < 0) throw new ArgumentException("Na must be non-negative", nameof(na));
        if (vitA < 0) throw new ArgumentException("VitA must be non-negative", nameof(vitA));
        if (vitC < 0) throw new ArgumentException("VitC must be non-negative", nameof(vitC));
        if (vitD < 0) throw new ArgumentException("VitD must be non-negative", nameof(vitD));
        if (ca < 0) throw new ArgumentException("Ca must be non-negative", nameof(ca));
        if (fe < 0) throw new ArgumentException("Fe must be non-negative", nameof(fe));
        if (fibra < 0) throw new ArgumentException("Fibra must be non-negative", nameof(fibra));
        if (potasio < 0) throw new ArgumentException("Potasio must be non-negative", nameof(potasio));
        if (agua < 0) throw new ArgumentException("Agua must be non-negative", nameof(agua));

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