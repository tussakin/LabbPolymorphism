namespace LabbPolymorphism;

// En klass som ärver från Geometri. Den har en constructor som sätter värdet på radien till 7
public class Cirkel : Geometri
{
    public Cirkel()
    {
        CircleRadius = 7;
    }

    //Property
    private double CircleRadius { get; }

    /* Override. På samma sätt som i alla klasser behöver vi bara returnera våra värden i en enkel uträkning,
 här multiplicerar vi pi med radien upphöjt i 2. Vi använder oss av Math.PI för att få ett accurate värde för pi, och
 Math.Pow() för att få upphöjt. Area för cirkel och ellips är samma sak, så här provar vi på detta sätt. */
    public override double Area()
    {
        return Math.PI * Math.Pow(CircleRadius, 2);
    }
}