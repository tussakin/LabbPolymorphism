namespace LabbPolymorphism;

// En klass som ärver från Geometri. Den har en constructor som sätter värdet på radien till 4.
public class Ellips : Geometri
{
    public Ellips()
    {
        EllipseRadius = 4;
    }

    // Property
    private double EllipseRadius { get; }

    /* Override. På samma sätt som i alla klasser behöver vi bara returnera våra värden i en enkel uträkning,
    här multiplicerar vi pi med radien upphöjt i 2. Ekvationen för ellipser är pi multiplicerat med radie i kvadrat
     Vi använder oss av Math.PI för att få ett accurate värde för pi. Arean för cirkel och ellips är samma, så för att prova
     olika sätt så gör vi radien multiplicerat med radien, vilket är samma sak som radien i kvadrat. */
    public override double Area()
    {
        return Math.PI * EllipseRadius * EllipseRadius;
    }
}