namespace LabbPolymorphism;

public class Rektangel : Geometri
{
    /* I detta program så kan man göra en constructor, men det räcker också med att göra member initializer som nedan.
     Fördelen med detta är att man inte behöver lägga till initialization i varje constructor du skapat om du tex. skapar
     en ny member variable, utan det räcker med att initialisera de som nedan. Det känns lättare att läsa och räcker gott
     och väl till denna kod. Finns såklart nackdelar med detta sätt också,bland annat  vid mer komplex kod, så kan det
     bli svårare att läsa, och det är inte lämpligt om du har  medlemmar med olika värden beroende på olika villkor.
     Men till denna kod räcker detta. */
    private static double RectangleBase => 23;
    private static double RectangleHeight => 12;

    /* En override på Area metoden som finns i Geometri. Eftersom vi har skapat RectangleBase och RectangleHeight så
     behöver vi endast returnera dessa värden multiplicerat med varandra. Det behöver inte vara mer komplicerat än så*/
    public override double Area()
    {
        return RectangleHeight * RectangleBase;
    }
}