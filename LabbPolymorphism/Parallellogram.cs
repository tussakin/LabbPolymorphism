namespace LabbPolymorphism;

// En klass som ärver från Geometri. Precis som i Rektangel så har vi här gjort member initializers, för att prova på olika sätt. 
public class Parallellogram : Geometri
{
    private double ParallelogramHeight => 5.5;
    private double ParallelogramLenght => 22;

    /* Override. På samma sätt som i alla klasser behöver vi bara returnera våra värden i en enkel uträkning,
 här höjden multiplicerat med längden*/
    public override double Area()
    {
        return ParallelogramHeight * ParallelogramLenght;
    }
}