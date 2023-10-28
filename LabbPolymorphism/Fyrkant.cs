namespace LabbPolymorphism;

// En klass som ärver från Geometri. Den har en constructor som sätter värdet på sidan till 13.
public class Fyrkant : Geometri
{
    public Fyrkant()
    {
        SquareSide = 13;
    }

    //Property
    private double SquareSide { get; }

    /* Override. På samma sätt som i alla klasser behöver vi bara returnera våra värden i en enkel uträkning,
     här sidan multiplicerat med sig själv*/
    public override double Area()
    {
        return SquareSide * SquareSide;
    }
}